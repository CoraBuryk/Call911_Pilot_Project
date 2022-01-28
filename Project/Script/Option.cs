using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project.Script.IVariations;

namespace Project.Script
{
    public static class Option
    {
        public static string GetVariation(this Variation variations)
        {
            if (variations == Variation.what)
                return String.Format("What is happening?"); 

            if (variations == Variation.adress)
                return String.Format("Your address?");

            if (variations == Variation.alone)
                return String.Format("Are you alone?");

            if (variations == Variation.basement)
                return String.Format("Hide in basement");

            if (variations == Variation.bedroom)
                return String.Format("Hide in bedroom");

            if (variations == Variation.calm)
                return String.Format("Keep calm");

            if (variations == Variation.confirm)
                return String.Format("Doors locked?");

            if (variations == Variation.handstand)
                return String.Format("A handstand?");

            if (variations == Variation.hear)
                return String.Format("You hear me?");

            if (variations == Variation.help)
                return String.Format("Help is on the way");

            if (variations == Variation.stay)
                return String.Format("Stay on with me");

            if (variations == Variation.name)
                return String.Format("Your name?");

            if (variations == Variation.police)
                return String.Format("Police on the way");

            if (variations == Variation.repeat)
                return String.Format("Repeat?");

            if (variations == Variation.say)
                return String.Format("What?");

            if (variations == Variation.secured)
                return String.Format("You secured?");

            if (variations == Variation.talk)
                return String.Format("Talk to me!");

            if (variations == Variation.there)
                return String.Format("You there?");

            if (variations == Variation.wrong)
                return String.Format("What's wrong?");

            if (variations == Variation.see)
                return String.Format("See him?");

            if (variations == Variation.strange)
                return String.Format("Something strange?");

            if (variations == Variation.describe)
                return String.Format("Describe him");

            if (variations == Variation.location)
                return String.Format("Your location?");

            if (variations == Variation.protect)
                return String.Format("Protect yourself");

            if (variations == Variation.hide)
                return String.Format("Hide somewhere");

            if (variations == Variation.prepared)
                return String.Format("Be prepared");

            if (variations == Variation.right)
                return String.Format("Are you all right?");

            return "";
        }
    }
}
