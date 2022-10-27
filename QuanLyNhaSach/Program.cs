
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Control;
using QuanLyNhaSach;
using System.Data.SqlClient;



//Class chua bien toan cuc
public static class Globals
{
  
    public static SqlConnection sqlcon;
    public static string name, username, role;
    public static int Slmin, Luongtonmax, Nomax, Tonbanmin, status = 1; // 1 la login, 2 la dashboard, 0 la tat
    public static bool tienthuvuottienno;
}
namespace QuanLyNhaSach
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Globals.sqlcon = new SqlConnection(@"server=LENSAKI\LPH; database=QLNS;integrated security=true");

            ApplicationConfiguration.Initialize();
            FrmLogin frmLogin = new FrmLogin();
            Dash_board dash_Board = new Dash_board();
            while (Globals.status != 0)
            {
                switch (Globals.status)
                {
                    case 1:
                        frmLogin = new FrmLogin();
                        Application.Run(frmLogin);
                        break;
                    case 2:
                        dash_Board = new Dash_board();
                        Application.Run(dash_Board);
                        break;
                }
            }          
        }
    }
}