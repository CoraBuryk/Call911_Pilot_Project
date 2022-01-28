using Project.Log;
using static Project.Script.IParagraph;

namespace Project.Script
{
    public class FromUserTwo
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
            TextResult = "...could you repeat that?";
            return TextResult;
        }
        public string SendBy2()
        {
            TextResult = "What is your address?";
            return TextResult;
        }
        public string SendBy3()
        {
            TextResult = $"Are you alone in your {Location.house}?";
            return TextResult;
        }
        public string SendBy4()
        {
            TextResult = "Can you confirm that all of your doors and windows are locked?";
            return TextResult;
        }
        public string SendBy5()
        {
            TextResult = "Are you still there?";
            return TextResult;
        }
        public string SendBy6()
        {
            TextResult = "What is happening?";
            return TextResult;
        }
        public string SendBy7()
        {
            TextResult = "He's...he's doing a handstand?";
            return TextResult;
        }
        public string SendBy8()
        {
            TextResult = "I need you to remain calm. I've put out the call and an officer is on his way.";
            return TextResult;
        }
        public string SendBy9()
        {
            TextResult = "We need to make sure all possible access points are secured. "
                + "Can you talk me through and confirm that your back door is locked?";
            return TextResult;
        }
        public string SendBy11()
        {
            TextResult = "Help is on the way.";
            return TextResult;
        }
        public string SendBy12()
        {
            TextResult = "Are you still there?";
            return TextResult;
        }

        public string SendBy13()
        {
            TextResult = "First you need to do is find something to protect yourself with." +
                $"Do you have something in your {Location.bedroom} or {Location.kitchen}?";
            return TextResult;
        }
        public string SendBy14()
        {
            TextResult = "I think for now that's about all we need";
            return TextResult;
        }
        public string SendBy16()
        {
            TextResult = $"And you're positive that you're alone in your {Location.house}?";
            return TextResult;
        }
        public string SendBy20()
        {
            TextResult = "What did you just say?";
            return TextResult;
        }
        public string SendBy21()
        {
            TextResult = "What happening?";
            return TextResult;
        }
    }
}
