using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXI.MainUI.Enums
{
    public enum PlayerState : byte
    {
        Standing = 0,
        Fighting = 1,
        Dead1 = 2,
        Dead2 = 3,
        Event = 4,
        Chocobo = 5,
        Healing = 33,
        Synthing = 44,
        Sitting = 47,
        Fishing = 56,
        FishBite = 57,
        Obtained = 58,
        RodBreak = 59,
        LineBreak = 60,
        CatchMonster = 61,
        LostCatch = 62,
        Unknown
    }
}
