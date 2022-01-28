using Project.Log;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Project.Script.IParagraph;

namespace Project.Script
{
    public class ForUserOne : CallsName, IParagraph
    {
        Logger<ForUserOne> logger = new();
        public string TextDial { get; set; }

        public string SentTo0()
        {
            TextDial = $"Yeah, hi, um...This is going to sound kind of strange but there's a man stumbling around in circles in my front {Location.yard}.";
            logger.Info("Start message for user");
            return TextDial;
        }
        public string SentTo1()
        {
            TextDial = $"He looks...sick, or lost, or drunk, or something. " +
                $"I just woke up to get a glass of water and heard snow crunching around underneath my front window so I peeked out..." +
                $"I'm looking at him now, he's about ten yards away from my window. Something's not right.";
            return TextDial;
        }
        public string SentTo2_1()
        {
            string fullName = Full();
            TextDial = $"{fullName}.";
            return TextDial;
        }
        public string SentTo2_2()
        {
            TextDial ="1617 Quarry Lane, in Pinella Pass.";
            return TextDial;
        }

        public string SentTo3_1()
        {
            TextDial = $"I'm staring right at it";
            return TextDial;
        }

        public string SentTo3_2()
        {
            TextDial = $"I'm alone here...";
            return TextDial;
        }

        public string SentTo4_1()
        {
           TextDial = $"I know that my front is definitely locked, but I'll go check my back door again really quick.";
            return TextDial;
        }
        public string SentTo4_2()
        {
            TextDial = $"I appreciate your help, by the way, I know this is kind of strange but I really hope that –";
            return TextDial;
        }
        public string SentTo5()
        {
            TextDial = $"He's... he's still in the {Location.yard}. But he's... what the... he's upside down...";
            return TextDial;
        }
        public string SentTo6()
        {
            TextDial = $"He's staring right at me... but he's... he's standing on his hands now. He's perfectly still," +
                $" staring straight at me. He's doing a handstand and he's smiling at me and not moving.";
            return TextDial;
        }
        public string SentTo7()
        {
            TextDial = $"I... I don't know how he... yeah, he's facing me and standing on his hands " +
                $"and he's got this huge smile and he's perfectly still... what the... please get someone out here NOW.";
            return TextDial;
        }
        public string SentTo8_1()
        {
            TextDial = $"His teeth are so huge... what the fuck, please help me...";
            return TextDial;
        }

        public string SentTo8_2()
        {
            TextDial = $"He's dressed all black...I can't really tell what he's wearing. He's got his face covered too";
            return TextDial;
        }

        public string SentTo9_1()
        {
            TextDial = $"Okay... I'm walking backwards now and keeping him in my sight...";
            return TextDial;
        }
        public string SentTo9_2()
        {
            TextDial = $"I'm downstairs, in my kitchen";
            return TextDial;
        }
        public string SentTo10_1()
        {
            TextDial = $"My hand is on the back doorknob now... it's locked. I need to check the deadbolt so I'm going to take my eyes off of him for a split second.";
            return TextDial;
        }
        public string SentTo10_2()
        {
            TextDial = $"I hear something outside";
            return TextDial;
        }

        public string SentTo12_1()
        {
            TextDial = $"He's... his face. It's up against the glass.";
            return TextDial;
        }

        public string SentTo12_2()
        {
            return TextDial;
        }

        public string SentTo13()
        {
            TextDial = $"I looked away for a split second and now... his face. It's pressed up against my front window. His teeth are huge and he's still smiling..." +
                $"There's no color in his eyes... Jesus please help me, why won't it just fucking move...";
            return TextDial;
        }
        public string SentTo14()
        {
            TextDial = $"He won't stop staring... he's going to hurt me...";
            return TextDial;
        }
        public string SentTo15_1()
        {
            TextDial = $"I... yes... yes, I'm going to lock myself in {Location.attic}";
            return TextDial;
        }

        public string SentTo15_2()
        {
            TextDial = $"Okay,okay... I'm going to take a baseball bat in my closet... I should use it";
            return TextDial;
        }

        public string SentTo16_1()
        {
            TextDial = $"Yes, I'm alone in the {Location.house}...";
            return TextDial;
        }
        public string SentTo16_2()
        {
            TextDial = $"He's here. He broke my basement window";
            return TextDial;
        }
        public string SentTo17_1()
        {
            TextDial = $"…wait a moment...";
            return TextDial;
        }
        public string SentTo17_2()
        {
            TextDial = $"he's inside...";
            return TextDial;
        }

        public string SentTo18_1()
        {
            TextDial = $"he's moving. He's shaking his head. He's telling me no. He can hear us.";
            return TextDial;
        }

        public string SentTo18_2()
        {
            TextDial = $"I can hear... I hear his footsteps";
            return TextDial;
        }

        public string SentTo19_1()
        {
            TextDial = $"He's telling me I'm not alone.";
            return TextDial;
        }
        public string SentTo19_2()
        {
            TextDial = $"Why isn't the police here yet?";
            return TextDial;
        }
        public string SentTo21_1()
        {
            return TextDial;
        }

        public string SentTo21_2()
        {
            return TextDial;
        }

        public string SentTo22_1()
        {
            TextDial = $"He's here";
            return TextDial;
        }

        public string SentTo22_2()
        {
            TextDial = $"He found me";
            return TextDial;
        }

        public string SentTo23_1()
        {
            TextDial = $"He's here...";
            return TextDial;
        }

        public string SentTo23_2()
        {
            TextDial = $"He's not person";
            return TextDial;
        }
    }
}
