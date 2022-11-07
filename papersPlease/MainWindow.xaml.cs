using papersPlease.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace papersPlease
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            vidComB.ItemsSource = Conection.entities.Vid.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(datePostDp.Text))
                mes += "Выбирете дату поступления\n";

            if (string.IsNullOrWhiteSpace(vidComB.Text))
                mes += "Выбирете вид\n";

            if (string.IsNullOrWhiteSpace(nickTb.Text))
                mes += "Выбирете кличку\n";

            if (string.IsNullOrWhiteSpace(serviceTb.Text))
                mes += "Выбирете условия содержания\n";

            if (string.IsNullOrWhiteSpace(dateEndDp.Text))
                mes += "Выбирете дату выпуска\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Jurnal jurnal = new Jurnal();
            jurnal.datePost = (DateTime)datePostDp.SelectedDate;
            Vid vid = (Vid)vidComB.SelectedItem;
            jurnal.idVid = vid.id;
            jurnal.nickName = nickTb.Text;
            jurnal.paspots = (bool)paspotrCB.IsChecked;
            jurnal.service = serviceTb.Text;
            jurnal.age = int.Parse(ageTb.Text);
            jurnal.dateEnd = (DateTime)dateEndDp.SelectedDate;

            Conection.entities.Jurnal.Add(jurnal);
            Conection.entities.SaveChanges();
            MessageBox.Show("Новая запись добавлена в журнал");


        }
    }
}
