using IntervalClock.Properties;
using System.Configuration;

namespace IntervalClock;

public class ClockConfig:ConfigurationSection
{
    private static readonly string ConfigFilePath = "./Settings.xml";

    private static ClockConfig? _instance;
    public static ClockConfig Instance
    {
        get
        {
            _instance ??= Load();
            return _instance;
        }
    }

    private static ClockConfig Load()
    {
        var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = ConfigFilePath };
        var config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        return (ClockConfig)config.GetSection("ClockConfig") ?? new ClockConfig();
    }

    /// <summary>
    /// 是否从不隐藏
    /// </summary>
    [ConfigurationProperty(nameof(NeverHideClock),IsRequired = true,DefaultValue = false)]
    public bool NeverHideClock
    {
        get => (bool)this[nameof(NeverHideClock)]; 
        set => this[nameof(NeverHideClock)] = value;
    }

    /// <summary>
    /// 每隔多少分钟弹出时钟
    /// </summary>
    [ConfigurationProperty(nameof(MinuteInterval), IsRequired = false, DefaultValue = 30)]
    public int MinuteInterval
    {
        get => (int)this[nameof(MinuteInterval)];
        set => this[ nameof(MinuteInterval)] = value;
    }

    /// <summary>
    /// 每次弹出时钟后，持续显示秒数
    /// </summary>
    [ConfigurationProperty(nameof(ShowClockTime), IsRequired = false, DefaultValue = 5)]
    public int ShowClockTime
    {
        get => (int)this[nameof(ShowClockTime)];
        set => this[nameof(ShowClockTime)] = value;
    }

    /// <summary>
    /// 是否启用定时器时钟
    /// </summary>
    [ConfigurationProperty(nameof(EnableClock), IsRequired = true, DefaultValue = true)]
    public bool EnableClock
    {
        get => (bool)this[nameof(EnableClock)];
        set => this[nameof(EnableClock)] = value;
    }

    /// <summary>
    /// 音频路径
    /// </summary>
    [ConfigurationProperty(nameof(SoundPath), IsRequired = false, DefaultValue = "")]
    public string SoundPath
    {
        get => (string)this[nameof(SoundPath)];
        set => this[nameof(SoundPath)] = value;
    }

    public void Save()
    {
        var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = ConfigFilePath };
        var config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        config.Sections.Remove("ClockConfig");
        var newClockConfig = new ClockConfig
        {
            NeverHideClock = this.NeverHideClock,
            MinuteInterval = this.MinuteInterval,
            ShowClockTime = this.ShowClockTime,
            EnableClock = this.EnableClock,
            SoundPath = this.SoundPath
        };
        config.Sections.Add("ClockConfig", newClockConfig);
        config.Save(ConfigurationSaveMode.Modified);
    }
};
