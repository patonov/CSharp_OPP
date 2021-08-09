using System;

namespace P01._HelloWorld_Before
{
    public class HelloWorld
    {
        private DateTime time;

        public HelloWorld(DateTime time)
        {
            this.Time = time;
        }

        public HelloWorld()
        {
            
        }

        public DateTime Time
        {
            get => this.time;

            set
            {
                if (value != null)
                {
                    this.time = value;
                }
                else
                {
                    this.time = DateTime.Now.Hour;
                }
            }
        }

        public string Greeting(string name)
        {
            if (this.Time < 12)
            {
                return "Good morning, " + name;
            }

            if (this.Time < 18)
            {
                return "Good afternoon, " + name;
            }

            return "Good evening, " + name;
        }
    }
}
