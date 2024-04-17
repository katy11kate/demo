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
using System.Xml.Linq;
using ООО_Техносервис.Model;

namespace ООО_Техносервис.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddRequests.xaml
    /// </summary>
    public partial class AddRequests : Window
    {
        public AddRequests()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (device.Text != null && opisanie.Text != null && type.Text != null && client.Text != null && employeecomb.Text != null)
            {

                Request pub = new Request
                {
                    Device = device.Text,
                    DescriptionProblem = opisanie.Text,
                    TypeProblem = type.SelectedIndex + 1,
                    Client = client.SelectedIndex + 1,

                    ResponsibleEmployee = employeecomb.SelectedIndex + 1,
                    DateAdd = DateTime.Now,
                    Status = 1,
                    
                };
                Apcontext.Context.Requests.Add(pub);
                Apcontext.Context.SaveChanges();
                MessageBox.Show("Заявка добавлена!");
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var employee = Apcontext.Context.Employees.Select(x => x.Firstname).ToList();
            foreach (var z in employee)
            {
                employeecomb.Items.Add(z);
            }
            var clentlist = Apcontext.Context.Clients.Select(x => x.Firstname).ToList();
            foreach (var z in clentlist)
            {
                client.Items.Add(z);
            }
            var problemslist = Apcontext.Context.TypesProblems.Select(x => x.NameProblem).ToList();
            foreach (var z in problemslist)
            {
                type.Items.Add(z);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
