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
        public static w_main w_Main;
        public w_main()
        {
            InitializeComponent();
            w_Main = this;
        }
    }
}
