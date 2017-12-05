using JetBrains.Application.Settings;

namespace AsyncConverter.Settings.AsyncSuffixOptions
{
    [SettingsKey(typeof(AsyncConverterSettings), "Settings for 'Async' suffix")]
    public class AsyncConverterAsyncSuffixSettings
    {
        [SettingsEntry(true, "Suggest adding 'Async' suffix to test method.")]
        public bool ExcludeTestMethodsFromAnalysis { get; set; }
    }
}