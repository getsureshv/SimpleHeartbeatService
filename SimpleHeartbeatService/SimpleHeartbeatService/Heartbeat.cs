using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Newtonsoft.Json;

namespace SimpleHeartbeatService
{
    public class Heartbeat
    {
        private readonly System.Timers.Timer _timer;

        public Heartbeat()
        {
            _timer = new System.Timers.Timer(300000) { AutoReset = true }; // timer set at 5 Mins
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // const string APPID = "7a47ca23234371289e9f4549179c8bfa"; App id for http://api.openweathermap.org/

            var path = "C://temp//weather.csv"; // please create C:\temp folder on windows pc

            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=Dallas,texas&appid=7a47ca23234371289e9f4549179c8bfa&units=imperial");
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<Weatherinfo>(json);

                if (!File.Exists(path))
                {
                    string header = $"Temperature,Units,Precipitation" + Environment.NewLine;
                    File.WriteAllText(path, header);
                }

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(result.main.temp + "," + "F" + "," + (result.weather[0].main == "Rain" ? true : false));
                }
            }
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

    }
}

