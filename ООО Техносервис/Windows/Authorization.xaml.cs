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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (login.Text != "" && password.Password != "")
            {
                var katalog = Apcontext.Context.Employees.Where(x => x.Password == password.Password && x.Login == login.Text).ToList();

                if (katalog.Count > 0)
                {
                    Apcontext.Name = katalog[0].Firstname + " " + katalog[0].Name + " " + katalog[0].Patronymic;
                    Apcontext.Id = katalog[0].Idemployee;
                    int post= katalog[0].Idemployee;
                    if (post == 1)
                    {
                        HomeWindow homeWindow = new HomeWindow();
                        homeWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        EmployeeWindow employeeWindow = new EmployeeWindow();
                        employeeWindow.Show();
                        this.Close();
                    }
                 
                   
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                  
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }
    }
}
