using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void ClientsListView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (List.SelectedValue != null)
            {
                var item = (dynamic)List.SelectedItem;
                int id = item.IdRequest;
                Apcontext.EnvironmentVariableTarget = id;
            
                Card window = new Card();
                window.Show();
                this.Close();
            }
        }
    

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (OooTachnoserviceContext db = new OooTachnoserviceContext())
            {
                string query = $"select id_request,date_add,device,type_problem,client,description_problem,status,date_end,responsible_employee," +
                    $"idtypes_problem,name_problem,idstatus,name_status  from requests join types_problem on " +
                    $"types_problem.idtypes_problem=requests.type_problem join statuses on requests.status=statuses.idstatus where  responsible_employee={Apcontext.Id}";
                var kat = Apcontext.Context.Requests.FromSqlRaw(query);
                foreach (var item in kat) { List.Items.Add(item); }
            }
            
        }
    }
}
