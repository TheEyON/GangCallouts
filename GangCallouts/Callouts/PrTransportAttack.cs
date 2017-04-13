using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Mod.Callouts;
using Rage;
using Rage.Native;
using Rage.Euphoria;
using Rage.Forms;

namespace GangCallouts.Callouts
{
    public class PrTransportAttack : Callout
    {
        Vector3 CallLocation;
        public override bool OnBeforeCalloutDisplayed()
        {
            this.CalloutMessage = "Callout1";
            this.CalloutPosition = this.CallLocation;

            return base.OnBeforeCalloutDisplayed();
        }

        public override bool OnCalloutAccepted()
        {
            return base.OnCalloutAccepted();
        }

        public override void OnCalloutNotAccepted()
        {
            base.OnCalloutNotAccepted();
        }

        public override void OnCalloutDisplayed()
        {
            base.OnCalloutDisplayed();
        }

        public override void Process()
        {
            base.Process();
            {

            }
        }

        public override void End()
        {
            base.End();
        }
    }
}
