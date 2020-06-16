using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IZ_NPCTracker.Models
{
    public class NPC
    {
        public string Name { get; set; }
        public ushort FightingDie { get; set; }
        public ushort ShootingDie { get; set; }
        public ushort ThrowingDie { get; set; }
        public ushort Vigor { get; set; }
        public ushort Strength { get; set; }
        public ushort Spirit { get; set; }
    }
}
