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

namespace Astar
{
    /// <summary>
    /// Interaction logic for w_main.xaml
    /// </summary>
    public partial class w_main : Window
    {
        List<List<uctrl.cell>> table_map = new List<List<uctrl.cell>>();
        public static w_main Main;
        public UInt16 Size = 20;
        public w_main()
        {
            InitializeComponent();
            Main = this;
            create_table(Size);
        }
        public void create_table(UInt16 cell_index)//tạo ra bản dựa vào tham số truyền vào
        {
            //clear map table
            table_map = new List<List<uctrl.cell>>();
            //clear control in table
            table.Children.Clear();
            table.RowDefinitions.Clear();
            table.ColumnDefinitions.Clear();
            //create control and map
            
            for (UInt16 y = 0;y<cell_index;y++)
            {
                List<uctrl.cell> lst = new List<uctrl.cell>();
                table.RowDefinitions.Add(new RowDefinition());
                table.ColumnDefinitions.Add(new ColumnDefinition());
                for (UInt16 x = 0; x < cell_index; x++)
                {
                    uctrl.cell cell = new uctrl.cell();
                    Grid.SetRow(cell, y);
                    Grid.SetColumn(cell, x);
                    lst.Add(cell);
                    table.Children.Add(cell);
                }
                table_map.Add(lst);
            }
        }
        private void tool_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        public void f_gettext()
        {
            string s = Size+"\n";
            for(UInt16 y=0;y<Size;y++)
            {
                for (UInt16 x = 0; x < Size; x++)
                {
                    s += x + "-" + y + "-" + table_map[y][x].index + "\n";
                }
            }
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\text.txt", s);
        }

        public void f_settext()
        {
            string[] s = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\text.txt").Split('\n');
            create_table(UInt16.Parse(s[0]));
            for(UInt16 i=1;i<s.Length-1;i++)
            {
                string[] data = s[i].Split('-');
                UInt16 x = UInt16.Parse(data[0]);
                UInt16 y = UInt16.Parse(data[1]);
                int index = int.Parse(data[2]);
                if (index == 100) table_map[y][x].light();
            }    
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            f_gettext();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            f_settext();
        }
    }
}
