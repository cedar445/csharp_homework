using problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    public class AlarmEventArgs
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
    }
    public delegate void AlarmDelegate(Object sender, AlarmEventArgs ea);
    public class Alarm
    {
        public event AlarmDelegate OnTick;
        public event AlarmDelegate OnAlarm;
        public void tick(int h, int m, int s)
        {
            Console.WriteLine($"Alarm is ticking on {h}:{m}:{s}");
            AlarmEventArgs ea = new AlarmEventArgs()
            {
                hour = h,
                minute = m,
                second = s
            };
            OnTick(this, ea);
        }
        public void alarm(int h, int m, int s)
        {
            Console.WriteLine($"Alarm is alarming on {h}:{m}:{s}");
            AlarmEventArgs ea = new AlarmEventArgs()
            {
                hour = h,
                minute = m,
                second = s
            };
            OnAlarm(this, ea);
        }
    }
    public class Test
    {
        public Alarm al = new Alarm();
        public Test()
        {
            al.OnTick += new AlarmDelegate(Alarm_Tick);
            al.OnAlarm += new AlarmDelegate(Alarm_Alarm);
        }
        void Alarm_Tick(object sender, AlarmEventArgs aea)
        {
            Console.WriteLine("alarm is ticking!");
        }
        void Alarm_Alarm(object sender, AlarmEventArgs aea)
        {
            Console.WriteLine("alarm is alarming!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.al.tick(0, 0, 0);
            test.al.alarm(12, 12, 12);
            Console.ReadKey();
        }
    }
}
