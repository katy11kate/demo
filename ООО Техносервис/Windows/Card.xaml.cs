using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Card.xaml
    /// </summary>
    public partial class Card : Window
    {
        public Card()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CommentsAdd win = new CommentsAdd();
            win.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            done.Visibility = Visibility.Hidden;
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
            var product = Apcontext.Context.Requests.Where(x => x.IdRequest == Apcontext.EnvironmentVariableTarget).ToList();
            device.Text = product[0].Device;
            opisanie.Text = product[0].DescriptionProblem;
           
            client.SelectedIndex = Convert.ToInt16(product[0].Client) - 1;
            employeecomb.SelectedIndex = Convert.ToInt16(product[0].ResponsibleEmployee) - 1;
            type.SelectedIndex = Convert.ToInt16(product[0].TypeProblem) - 1;
           
            using (OooTachnoserviceContext db = new OooTachnoserviceContext())
            {
                string query = $"select * from coments where id_request={Apcontext.EnvironmentVariableTarget} ";
                var kat = Apcontext.Context.Coments.FromSqlRaw(query);
                foreach (var item in kat) { List.Items.Add(item); }
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            var clother = Apcontext.Context.Requests.FirstOrDefault(x => x.IdRequest == Apcontext.EnvironmentVariableTarget);

            clother.Status = 2;
          

            Apcontext.Context.SaveChanges();
            MessageBox.Show("Статус изменен!");
            save.Visibility= Visibility.Hidden;
            done.Visibility = Visibility.Visible;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow=new EmployeeWindow();
            employeeWindow.Show();
            this.Close();
        }

        private void done_Click(object sender, RoutedEventArgs e)
        {
            var clother = Apcontext.Context.Requests.FirstOrDefault(x => x.IdRequest == Apcontext.EnvironmentVariableTarget);

            clother.Status = 3;


            Apcontext.Context.SaveChanges();
            MessageBox.Show("Статус изменен!");
            done.Visibility = Visibility.Hidden;
        }
    }
}
