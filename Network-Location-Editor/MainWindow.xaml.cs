using NetworkLocationEditor.Entity;
using NetworkLocationEditor.Manager;
using System.Collections.Generic;
using System.Windows;

namespace NetworkLocationEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly INetworkLocationManager networkLocationManager;

        public MainWindow()
        {
            InitializeComponent();
            this.networkLocationManager = new NetworkLocationManager();
            RefreshList();
        }

        public void RefreshList()
        {
            List<NetworkLocation> locations = networkLocationManager.List();
            listView.ItemsSource = locations;
        }
    }
}
