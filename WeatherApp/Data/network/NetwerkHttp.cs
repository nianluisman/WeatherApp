using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.ViewModels;
using System;

namespace WeatherApp.Data.network
{
   public class NetwerkHttp : ReactiveObject
    {
        [ReactiveUI] public string username;
      public  async Task Network()
        {
            
            var client = new HttpClient();
            var mainwindow = new MainWindowViewModel();
            HttpResponseMessage responseMessage = await client.GetAsync("https://www.yr.no/nb/v%C3%A6rvarsel/daglig-tabell/2-2752623/Nederland/Overijssel/Gemeente%20Hardenberg/Kloosterhaar");
            if (responseMessage.IsSuccessStatusCode)
                this.WhenAnyValue`<string>(  mainwindow.Greeting = "fun man";);
            mainwindow.Greeting = "fun man";
        }
    }
}
