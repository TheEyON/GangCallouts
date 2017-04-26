using LSPD_First_Response.Mod.API;
using Rage;
using GangCallouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangCallouts.CommonStuff
{
    class pedFuncs
    {

        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        // Gang Peds
        string pickOneGangPed(string faction)
        {
            string chosenPed = string.Empty;
            switch (faction)
            {
                case "ballas":
                    chosenPed = gangPeds.ballas[MathHelper.GetRandomInteger(gangPeds.ballas.Length)];
                    break;

                case "families":
                    chosenPed = gangPeds.families[MathHelper.GetRandomInteger(gangPeds.families.Length)];
                    break;

                case "losts":
                    chosenPed = gangPeds.losts[MathHelper.GetRandomInteger(gangPeds.losts.Length)];
                    break;

                case "rednecks":
                    chosenPed = gangPeds.rednecks[MathHelper.GetRandomInteger(gangPeds.rednecks.Length)];
                    break;

                case "vagos":
                    chosenPed = gangPeds.vagos[MathHelper.GetRandomInteger(gangPeds.vagos.Length)];
                    break;

                case default():
                    chosenPed = gangPeds.rednecks[MathHelper.GetRandomInteger(gangPeds.rednecks.Length)];
                    break;

            }
            return chosenPed;
        }
        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        // Mafia Peds
        string pickOneMafiaPed(string faction)
        {
            string chosenPed = string.Empty;
            switch (faction)
            {
                case "armenian":
                    chosenPed = mafiaPeds.armenian[MathHelper.GetRandomInteger(mafiaPeds.armenian.Length)];
                    break;

                case "cartel":
                    chosenPed = mafiaPeds.cartel[MathHelper.GetRandomInteger(mafiaPeds.cartel.Length)];
                    break;

                case "korean":
                    chosenPed = mafiaPeds.korean[MathHelper.GetRandomInteger(mafiaPeds.korean.Length)];
                    break;

                case "triads":
                    chosenPed = mafiaPeds.triads[MathHelper.GetRandomInteger(mafiaPeds.triads.Length)];
                    break;

               case default:
                    chosenPed = mafiaPeds.armenian[MathHelper.GetRandomInteger(mafiaPeds.armenian.Length)];
                    break;

            }
            return chosenPed;
        }
        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
    }
}













