using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntervalClock.Forms;
using IntervalClock.Properties;
using NAudio.Vorbis;
using NAudio.Wave;

namespace IntervalClock
{
    public class ClockAppContext:ApplicationContext
    {
        private readonly NotifyIcon _trayIcon;
        private readonly ClockTimer _timer;
        private readonly SynchronizationContext _syncContext;

        public ClockAppContext()
        {
            _trayIcon = new NotifyIcon()
            {
                Icon = Resources.MyIcon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items =
                    {
                        new ToolStripMenuItem("设置",null,OpenSettings),
                        new ToolStripMenuItem("退出", null, Exit)
                    }
                },
                Visible = true,
            };
            _trayIcon.DoubleClick += OpenSettings;

            // 捕获主线程的 SynchronizationContext
            _syncContext = SynchronizationContext.Current!;
            // 生成Timer和对应的方法
            _timer = new ClockTimer(PlaySoundAndShow);
        }

        private void PlaySoundAndShow()
        {
            Debug.WriteLine("时间到");
            _syncContext.Post(_ =>
            {
                new ClockForm().Show();
            },null);
            Task.Run(() =>
            {
                using var audioFile = new MemoryStream(Resources.ClockSound);
                using var outputDevice = new WaveOutEvent();
                var vorbisReader = new VorbisWaveReader(audioFile);
                outputDevice.Init(vorbisReader);
                outputDevice.Play();
                // 等待音频播放完成
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            });
        }

        private void OpenSettings(object? sender, EventArgs e)
        {
            new SettingsForm(_timer).Show();
        }

        private void Exit(object? sender, EventArgs e)
        {
            _trayIcon.Visible = false;
            Application.Exit();
        }
    }
}
