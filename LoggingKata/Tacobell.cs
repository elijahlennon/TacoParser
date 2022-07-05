using System;
using System.Collections.Concurrent;
using System.Text;


namespace LoggingKata
{
    public class Tacobell : ITrackable
    {
        public Tacobell()
        {
        }

        public string Name { get; set; }
        public Point Location { get; set; }
    }
}