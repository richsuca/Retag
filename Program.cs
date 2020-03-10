using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Retag
{
    static class Program
    {
        public static readonly HttpClient webClient = new HttpClient();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }

    /*
    "href": "https:\/\/news.ycombinator.com\/item?id=22473209",
    "description": "Ask HN: How to Take Good Notes? | Hacker News",
    "extended": "A hacker news discussion with lots of ideas about note taking, note organisation, note searching.",
    "meta": "cd31d08d4dd1f9dc50130835",
    "hash": "41e6d108aed8c2c50ec8a15f",
    "time": "2020-03-03T20:00:22Z",
    "shared": "no",
    "toread": "no",
    "tags": "learning note"
    */
    class Pin
    {
        public string Href;
        public string Description;
        public string Extended;
        public string TagsText;
        public string[] Tags;

        public override string ToString()
        {
            return Href + "[" + TagsText + "]";
        }
    }
}
