using LSPD_First_Response.Mod.API;
using Rage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangCallouts
{
    public class Main : Plugin
    {
        public override void Initialize() { Functions.OnOnDutyStateChanged += OnOnDutyStateChangedHandler; Game.LogTrivial("Gang Callouts v1.0 has been successfully loaded !"); }

        public override void Finally() { Game.LogTrivial("Gang Callouts by Eyon has been cleaned up !"); }

        private static void OnOnDutyStateChangedHandler(bool OnDuty) { if (OnDuty) { RegisterCallouts(); } }

        private static void RegisterCallouts()
        {             //We will implement this method later.        
        }
    }  
}
