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
using RoomLibrary;

namespace OfficeExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Room> lstRooms = new List<Room>(); //создание списка комнат
        /*    Room room = new Room();
            LivingRoom livingroom = new LivingRoom();
            Office office = new Office();   */
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLength = Convert.ToDouble(TBLengthR.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
            lstRooms.Add(room); //добавление в список
            //обработчик события, который сохраняет информацию о комнате
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingroom = new LivingRoom();
            livingroom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingroom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingroom.NumWin = Convert.ToInt32(TBNumW.Text);
            lstRooms.Add(livingroom); // добавление в список

        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();
            office.RoomLength = Convert.ToDouble(TBLengthO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
            lstRooms.Add(office); //добавление в список
        }
        
        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = ""; //очищаем метку
            //вывод информации из списка
            foreach (Room r in lstRooms)
                ListRooms.Content += r.Info() + "\n";
            /*    ListRooms.Content += room.Info() + "\n";
                ListRooms.Content += livingroom.Info() + "\n";
                ListRooms.Content += office.Info();
                //теперь в метке ListRooms есть информация обо всех трех объектах   */
        }
    }
}
