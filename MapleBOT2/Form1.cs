using daymap.memory;

using MemoryEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleBOT2
{
    public partial class Form1 : Form
    {
        public LocalPlayer currentPlayer = new LocalPlayer();
        private Memory memory;
        public Process Maple2Process;
        public Timer appUpdate;
        public Timer teleportLoop;
        public int currentTpIndex = 0;
        public static BindingList<Vector3> Locations3D = new BindingList<Vector3>();
        public Form1()
        {
            InitializeComponent();
        }

        public struct OffSets
        {
            internal const int MOVESPEED_1 = 0x1B4;
            internal const int MOVESPEED_2 = 0x400;
            internal const int ATKSPEED_1 = 0x1B4;
            internal const int ATKSPEED_2 = 0x3F8;
            internal const int JUMPHEIGHT_1 = 0x1B4;
            internal const int JUMPHEIGHT_2 = 0x440;
            internal const int Z_COORD_1 = 0x1B4;
            internal const int Z_COORD_2 = 0xE8;
            internal const int Z_COORD_3 = 0x4;
            internal const int Z_COORD_4 = 0x11C;
            internal const int X_COORD_1 = 0x1B4;
            internal const int X_COORD_2 = 0xE8;
            internal const int X_COORD_3 = 0x4;
            internal const int X_COORD_4 = 0x10C;
            internal const int Y_COORD_1 = 0x1B4;
            internal const int Y_COORD_2 = 0xE8;
            internal const int Y_COORD_3 = 0x4;
            internal const int Y_COORD_4 = 0x114;
            internal const int FACE_ANGLE_1 = 0x1B4;
            internal const int FACE_ANGLE_2 = 0x1438;
            internal const int DELTA_SPEED_1 = 0x1B4;
            internal const int DELTA_SPEED_2 = 0x120;
            internal const int JUMP_DISTANCE_1 = 0x1B4;
            internal const int JUMP_DISTANCE_2 = 0x134;
            internal const int SIZE_1 = 0x1B4;
            internal const int SIZE_2 = 0x80;
            internal const int TARGET_1 = 0x20;
            internal const int TARGET_2 = 0x8;
            internal const int TARGET_3 = 0x44;
            internal const int TARGET_4 = 0x1F0;
            internal const int ACCURACY_1 = 0x1B4;
            internal const int ACCURACY_2 = 0x408;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Maple2Process = Process.GetProcessesByName("MapleStory2").First();
            if (Maple2Process == null)
            {
                MessageBox.Show("Can't find MapleStory2 Process", "Process Error");
                Environment.Exit(0);
                return;
            }
            memory = new Memory();
            appUpdate = new Timer();
            appUpdate.Tick += new EventHandler(this.Pulse);
            appUpdate.Interval = 50;
            appUpdate.Start();

        }


        private void Pulse(object sender, EventArgs e)
        {

            if (memory.OpenProcess("MapleStory2"))
            {
                var _baseAddr = Maple2Process.MainModule.BaseAddress;
                var _localPlayer = IntPtr.Add(_baseAddr, 0x0166BA64);

                var m_movementSpeed = memory.ReadInt((int)(_localPlayer), new int[] { OffSets.MOVESPEED_1, OffSets.MOVESPEED_2 });
                var m_attackSpeed = memory.ReadInt((int)(_localPlayer), new int[] { OffSets.ATKSPEED_1, OffSets.ATKSPEED_2 });
                var m_jumpHeight = memory.ReadInt((int)(_localPlayer), new int[] { OffSets.JUMPHEIGHT_1, OffSets.JUMPHEIGHT_2 });
                var m_jumpDistance = memory.ReadFloat((int)(_localPlayer), new int[] { OffSets.JUMP_DISTANCE_1, OffSets.JUMP_DISTANCE_2 });
                var m_deltaSpeed = memory.ReadFloat((int)(_localPlayer), new int[] { OffSets.DELTA_SPEED_1, OffSets.DELTA_SPEED_2 });

                var x = memory.ReadFloat((int)(_localPlayer), new int[] { OffSets.X_COORD_1, OffSets.X_COORD_2, OffSets.X_COORD_3, OffSets.X_COORD_4 });
                var y = memory.ReadFloat((int)(_localPlayer), new int[] { OffSets.Y_COORD_1, OffSets.Y_COORD_2, OffSets.Y_COORD_3, OffSets.Y_COORD_4 });
                var Z = memory.ReadFloat((int)(_localPlayer), new int[] { OffSets.Z_COORD_1, OffSets.Z_COORD_2, OffSets.Z_COORD_3, OffSets.Z_COORD_4 });

                currentPlayer.Location3D = new Vector3(x, y, Z);

                //FirstValue
                if (currentPlayer.BaseMovementSpeed == 0)
                {
                    currentPlayer.BaseMovementSpeed = (int)m_movementSpeed;
                }

                if (currentPlayer.BaseAttackSpeed == 0)
                {
                    currentPlayer.BaseAttackSpeed = (int)m_attackSpeed;
                }

                if (currentPlayer.JumpDistanceModifier == 0)
                {
                    currentPlayer.JumpDistanceModifier = m_jumpDistance;
                }

                if (currentPlayer.JumpHeightModifier == 0)
                {
                    currentPlayer.JumpHeightModifier = m_jumpHeight;
                }

                if (currentPlayer.ModifiedDeltaSpeed == 0)
                {
                    currentPlayer.ModifiedDeltaSpeed = m_deltaSpeed;
                }


                memory.Write((int)_localPlayer, new int[] { OffSets.ATKSPEED_1, OffSets.ATKSPEED_2 }, (int)_attackSpeedModifier.Value);
                memory.Write((int)_localPlayer, new int[] { OffSets.MOVESPEED_1, OffSets.MOVESPEED_2 }, (int)_movementSpeedModifier.Value);
                memory.Write((int)_localPlayer, new int[] { OffSets.JUMPHEIGHT_1, OffSets.JUMPHEIGHT_2 }, (int)_jumpHeightModifier.Value);
                memory.Write((int)_localPlayer, new int[] { OffSets.JUMP_DISTANCE_1, OffSets.JUMP_DISTANCE_2 }, (float)_jumpDistanceModifier.Value);
                memory.Write((int)_localPlayer, new int[] { OffSets.DELTA_SPEED_1, OffSets.DELTA_SPEED_2 }, (float)_surfSpdModifier.Value);

                _attackSpeed.Text = m_attackSpeed + " %";
                _movementSpeed.Text = m_movementSpeed + " %";
                _jumpHeightLbl.Text = m_jumpHeight + " m";
                _jumpDistLbl.Text = m_jumpDistance + " m";
                _surfSpdLbl.Text = m_deltaSpeed + " m/s";
                _xValue.Text = x + "";
                _yValue.Text = y + "";
                _zValue.Text = Z + "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Locations3D.Add(new Vector3(currentPlayer.Location3D.X, currentPlayer.Location3D.Y, currentPlayer.Location3D.Z));
            _locations.DataSource = Locations3D;
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }


        private void openGame()
        {


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void _attackSpeedModifier_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Teleport(float X, float Y, float Z)
        {
            if (memory.OpenProcess("MapleStory2"))
            {
                var _baseAddr = Maple2Process.MainModule.BaseAddress;
                var _localPlayer = IntPtr.Add(_baseAddr, 0x0166BA64);
                memory.Write((int)_localPlayer, new int[] { OffSets.X_COORD_1, OffSets.X_COORD_2, OffSets.X_COORD_3, OffSets.X_COORD_4 }, X);
                memory.Write((int)_localPlayer, new int[] { OffSets.Y_COORD_1, OffSets.Y_COORD_2, OffSets.Y_COORD_3, OffSets.Y_COORD_4 }, Y);
                memory.Write((int)_localPlayer, new int[] { OffSets.Z_COORD_1, OffSets.Z_COORD_2, OffSets.Z_COORD_3, OffSets.Z_COORD_4 }, Z);
            }
        }

        private void _locations_DoubleClick(object sender, EventArgs e)
        {
            if (Locations3D[_locations.SelectedIndex] != null)
            {
                Teleport(Locations3D[_locations.SelectedIndex].X, Locations3D[_locations.SelectedIndex].Y, Locations3D[_locations.SelectedIndex].Z);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Locations3D.Clear();
            _locations.DataSource = Locations3D;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teleportLoop = new Timer();
            teleportLoop.Tick += new EventHandler(this.TpLoop);
            teleportLoop.Interval = 50;
            teleportLoop.Start();
        }

        private void TpLoop(object sender, EventArgs e)
        {

            //Reset Loop test 
            if(currentTpIndex > Locations3D.Count-1)
            {
                currentTpIndex = 0;
                return;
            }
            if (currentTpIndex <= Locations3D.Count-1)
            {
                Teleport(Locations3D[currentTpIndex].X, Locations3D[currentTpIndex].Y, Locations3D[currentTpIndex].Z);
                currentTpIndex++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (teleportLoop.Enabled)
            {
                teleportLoop.Stop();
                currentTpIndex = 0;
            }
        }
    }
}
