using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace IntervalClock
{
    public class ClockTimer
    {
        private readonly Timer _timer = new();
        private readonly Action _action;
        private readonly ClockConfig _config = ClockConfig.Instance;

        public ClockTimer(Action action)
        {
            _action = action;

            Debug.WriteLine("初始化闹钟");
            _timer.Elapsed += OnTimeout;
            _timer.AutoReset = false;
            UpdateInterval();
        }

        private void SetNextInterval()
        {
            var intervalInMinutes = _config.MinuteInterval;
            var now = DateTime.Now;
            var currentMinute = now.Minute;
            var minutesUntilNextInterval = intervalInMinutes - (currentMinute % intervalInMinutes);
            if (minutesUntilNextInterval == intervalInMinutes)
            {
                minutesUntilNextInterval = 0;
            }
            // 有剩余时间
            double interval = (minutesUntilNextInterval * 60 - now.Second) * 1000 - now.Millisecond;
            // 说明刚刚经过
            if (minutesUntilNextInterval < 1)
            {
                interval = (intervalInMinutes * 60 - now.Second) *1000 - now.Millisecond;
            }
            _timer.Interval = interval;
            Debug.WriteLine("重设下次时间：{0}秒后",interval/1000);
        }

        public void UpdateInterval()
        {
            if (_config.EnableClock)
            {
                SetNextInterval();
                _timer.Start();
            }
            else
            {
                _timer.Stop();
            }
        }
        private void OnTimeout(object? source, ElapsedEventArgs e)
        {
            _action();
            UpdateInterval();
        }
    }
}
