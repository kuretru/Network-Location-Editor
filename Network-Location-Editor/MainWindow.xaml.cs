using NetworkLocationEditor.Entity;
using NetworkLocationEditor.Manager;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace NetworkLocationEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly INetworkLocationManager networkLocationManager;

        private List<NetworkLocation> selectedItems;

        public MainWindow()
        {
            InitializeComponent();
            this.networkLocationManager = new NetworkLocationManager();
            this.selectedItems = new List<NetworkLocation>();
            RefreshList();
        }

        private void RefreshList()
        {
            List<NetworkLocation> locations = networkLocationManager.List();
            listView.ItemsSource = locations;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("没有选中的配置", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            string text = "确定要删除" + selectedItems.Count + "个网络配置吗";
            MessageBoxResult messageBoxResult = MessageBox.Show(text, "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                foreach(NetworkLocation record in selectedItems)
                {
                    networkLocationManager.Remove(record);
                }
                RefreshList();
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IList<object> removedList = (IList<object>)e.RemovedItems;
            foreach (object item in removedList)
            {
                selectedItems.Remove((NetworkLocation)item);
            }
            IList<object> addedList = (IList<object>)e.AddedItems;
            foreach (object item in addedList)
            {
                selectedItems.Add((NetworkLocation)item);
            }
        }
    }
}
