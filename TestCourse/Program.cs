using System;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TestCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            CBReference.DailyInfoSoapClient.EndpointConfiguration endpointConfiguration = new CBReference.DailyInfoSoapClient.EndpointConfiguration();
            CBReference.DailyInfoSoapClient dailyInfoSoap = new CBReference.DailyInfoSoapClient(endpointConfiguration);
            try
            {
                var xmlNode = dailyInfoSoap.GetCursOnDateXMLAsync(DateTime.Now).Result;
                var serializer = new XmlSerializer(typeof(ValuteData));
                decimal valuteCursUSD;
                decimal valuteCursEUR;
                using (XmlNodeReader reader = new XmlNodeReader(xmlNode))
                {
                    ValuteData result;
                    result = (ValuteData)serializer.Deserialize(reader);
                    valuteCursUSD = result.ValuteCursOnDate.Where(s=>s.Vcode == 840).FirstOrDefault().Vcurs;
                    valuteCursEUR = result.ValuteCursOnDate.Where(s => s.Vcode == 978).FirstOrDefault().Vcurs;
                }
                Console.WriteLine($"Текущий курс доллара {valuteCursUSD} р");
                Console.WriteLine($"Текущий курс евро {valuteCursEUR} р");
            }

            catch(Exception ex)
            {
                Console.WriteLine("Что-то не так, "+ex.Message);

            }
        
        }
    }
}

