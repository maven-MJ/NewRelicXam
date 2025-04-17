using System;
using NewRelic.Xamarin.Plugin;
using Xamarin.Essentials;

namespace DemoApp
{
    public static class NewRelicAnalyticsProvider
    {
        public static void Start()
        {
            StartNewRelic();
        }

        private static void StartNewRelic()
        {
            CrossNewRelicClient.Current.HandleUncaughtException(false);
            AgentStartConfiguration agentConfig = new AgentStartConfiguration();

            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                CrossNewRelicClient.Current.Start("key", agentConfig);
            }
            else if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                CrossNewRelicClient.Current.Start("key", agentConfig);
            }
        }

    }
}

