using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using oop_kr.Models;
using oop_kr.Views;
using System.Configuration;
using oop_kr.Presenters;

namespace oop_kr
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataBaseHelper.InitializeDatabase();

            string sqliteConnectionString = ConfigurationManager.ConnectionStrings["SqliteConnection"].ConnectionString;
            IMainView view = new MainForm();
            new MainPresenter(view, sqliteConnectionString);
            Application.Run((Form)view);
        }
    }
}
