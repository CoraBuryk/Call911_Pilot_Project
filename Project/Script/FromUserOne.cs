using Project.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project.Script.IParagraph;

namespace Project.Script
{
    public class FromUserOne
    {
        Logger<FromUserOne> logger = new();
        public string TextResult { get; set; }
      
        public string SendBy0()
        {
            TextResult = "911. What's you emergency?";
            logger.Info("Message from user start");
            return TextResult;
        }
        public string SendBy1()
        {
            TextResult = "What's going on?";
            return TextResult;
        }
        public string SendBy2()
        {
            TextResult = "What is your name?";
            return TextResult;
        }
        public string SendBy3()
        {
            TextResult = $"Well. Are you currently see this man?";
            return TextResult;
        }
        public string SendBy4()
        {
            TextResult = "Stay on the phone with me.";
            return TextResult;
        }
        public string SendBy5()
        {
            TextResult = "What are you seeing?";
            return TextResult;
        }
        public string SendBy6()
        {
            TextResult = "Is anything strange going on?";
            return TextResult;
        }
        public string SendBy7()
        {
            TextResult = "What did you just say?";
            return TextResult;
        }
        public string SendBy8()
        {
            TextResult = "Can you describe this person?";
            return TextResult;
        }
        public string SendBy9()
        {
            TextResult = "Where are you right now in your house?";
            return TextResult;
        }
        public string SendBy11()
        {            
            TextResult = "Just stay on the phone with me, everything's going to be alright.";
            return TextResult;
        }
        public string SendBy12()
        {
            TextResult = "Talk to me! I can help you";
            return TextResult;
        }

        public string SendBy13()
        {
            TextResult = $"I need you to go to the nearest room and lock yourself inside of it. " +
                $"Do you have a {Location.basement} or an {Location.attic} that you can lock yourself in?";
            return TextResult;
        }
        public string SendBy14()
        {
            TextResult = "Can you hear me?";
            return TextResult;
        }
        public string SendBy16()
        {
            TextResult = $"Stay prepared and vigilant";
            return TextResult;
        }
        public string SendBy20()
        {
            TextResult = "The police should be there in about 1 minute or so";
            return TextResult;
        }
        public string SendBy21()
        {
            TextResult = "Where are you?";
            return TextResult;
        }
    }
}
