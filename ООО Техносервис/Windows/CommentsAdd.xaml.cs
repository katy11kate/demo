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
    /// Логика взаимодействия для CommentsAdd.xaml
    /// </summary>
    public partial class CommentsAdd : Window
    {
        public CommentsAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (coment.Text != null )
            {

                Coment pub = new Coment
                {
                    TextComenrs = coment.Text,
                    IdEmployee = Apcontext.Id,
                    IdRequest=Apcontext.EnvironmentVariableTarget
           


                };
                Apcontext.Context.Coments.Add(pub);
                Apcontext.Context.SaveChanges();
                MessageBox.Show("Done!");
                Card card = new Card();
                card.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
    }
}
