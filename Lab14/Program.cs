using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14
{
    static class Data
    {
        public static double Len1 { get; set; }
        public static double Len2 { get; set; }
        public static double Len3 { get; set; }
        public static double Per { get; set; }
        public static double Sq { get; set; }
        public static bool IsPer { get; set; }
        public static bool IsSq { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
