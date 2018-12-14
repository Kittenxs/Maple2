using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleBOT2
{
    public class LocalPlayer
    {
        public Vector3 Location3D { get; set; }
        public int BaseMovementSpeed { get; set; }
        public int BaseAttackSpeed { get; set; }
        public int ModifiedMovementSpeed { get; set; }
        public int ModifiedAttackSpeed { get; set; }
        public int Accuracy { get; set; }
        public float JumpDistanceModifier { get; set; }
        public float JumpHeightModifier { get; set; }
        public float ModifiedDeltaSpeed { get; set; }

        public LocalPlayer()
        {
            Location3D = null;

            BaseMovementSpeed = 0;
            BaseAttackSpeed = 0;

            ModifiedMovementSpeed = 0;
            ModifiedAttackSpeed = 0;

            Accuracy = 0;
            JumpDistanceModifier = 0;
            JumpHeightModifier = 0;
            ModifiedDeltaSpeed = 0;
        }
    }
}
