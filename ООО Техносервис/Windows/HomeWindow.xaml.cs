using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ООО_Техносервис.Model;

namespace ООО_Техносервис.Windows
{
    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            using (OooTachnoserviceContext db = new OooTachnoserviceContext())
            {
                string query = "select id_request,date_add,device,type_problem,client,description_problem,status,date_end,responsible_employee," +
                    "idtypes_problem,name_problem,idstatus,name_status  from requests join types_problem on " +
                    "types_problem.idtypes_problem=requests.type_problem join statuses on requests.status=statuses.idstatus ";
                var kat = Apcontext.Context.Requests.FromSqlRaw(query);
                foreach (var item in kat) { List.Items.Add(item); }
            }
            Namefio.Text = Apcontext.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddRequests win = new AddRequests();    
            win.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
    }
}
