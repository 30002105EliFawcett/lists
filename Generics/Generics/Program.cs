using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=10");

            Console.WriteLine(json);

            List<CustomJson> data = new JavaScriptSerializer().Deserialize<List<CustomJson>>(json);


        foreach (CustomJson x in data)
            {
                Console.WriteLine("Name: {0} {1} \nGender: {2}\nRegion: {3}\nAge: {4}\nTitle: {5}\nPhone: {6}\nBirthday: {7}\nEmail: {8}\nPassword: {9}\nCredit_card: {10}\nPhoto: {11}\n", x.name, x.surname, x.gender, x.region, x.age, x.title, x.phone, x.birthday, x.email, x.password, x.credit_card, x.photo);
            }
           
        }

    }
    class CustomJson
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string region { get; set; }
        public int age { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public Birthday birthday { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Credit_card credit_card { get; set; }
        public string photo { get; set; }

    }
    class Birthday
    {
        public string dmy { get; set; }
        public string mdy { get; set; }
        public int raw { get; set; }

    }
    class Credit_card
    {
        public string expiration { get; set; }
        public string number { get; set; }
        public int pin { get; set; }
        public int security { get; set; }
    }

    
}
