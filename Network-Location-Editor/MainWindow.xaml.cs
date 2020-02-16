using NetworkLocationEditor.Entity;
using NetworkLocationEditor.Manager;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace NetworkLocationEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly INetworkLocationManager networkLocationManager;

        private readonly List<NetworkLocation> selectedItems;

        public MainWindow()
        {
            InitializeComponent();
            networkLocationManager = new NetworkLocationManager();
            selectedItems = new List<NetworkLocation>();
            RefreshList();
        }

        private void RefreshList()
        {
            List<NetworkLocation> locations = networkLocationManager.List();
            listView.ItemsSource = locations;
            listCountLabel.Content = "共有" + locations.Count + "个网络配置";
        }

        private void DeleteList(List<NetworkLocation> list)
        {
            foreach (NetworkLocation record in list)
            {
                networkLocationManager.Remove(record);
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshList();
            editorGrid.DataContext = null;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("没有选中的配置", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = "确定要删除" + selectedItems.Count + "个网络配置吗";
            MessageBoxResult messageBoxResult = MessageBox.Show(text, "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                DeleteList(selectedItems);
                RefreshList();
            }
        }

        private void CleanButton_Click(object sender, RoutedEventArgs e)
        {
            List<NetworkLocation> invalids = networkLocationManager.ListInvalid();
            if (invalids.Count == 0)
            {
                MessageBox.Show("不存在无效的配置", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            string text = "确定要删除" + invalids.Count + "个无效的网络配置吗";
            MessageBoxResult messageBoxResult = MessageBox.Show(text, "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                DeleteList(invalids);
                RefreshList();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            NetworkLocation location = (NetworkLocation)editorGrid.DataContext;
            if (location.Name.Trim().Length == 0)
            {
                MessageBox.Show("网络名称不能为空", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            networkLocationManager.Update(location);
            RefreshList();
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

            if (listView.SelectedItem != null)
            {
                NetworkLocation location = (NetworkLocation)listView.SelectedItem;
                editorGrid.DataContext = location.Clone();
            }
        }

        /// <summary>
        /// Copyed from https://docs.microsoft.com/en-us/dotnet/framework/wpf/controls/how-to-sort-a-gridview-column-when-a-header-is-clicked?redirectedfrom=MSDN
        /// </summary>
        private GridViewColumnHeader lastHeaderClicked = null;

        private ListSortDirection lastDirection = ListSortDirection.Ascending;

        private void ListView_HeaderClick(object sender, RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;
            if (headerClicked != null)
            {
                if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
                {
                    if (headerClicked != lastHeaderClicked)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        direction = lastDirection == ListSortDirection.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
                    }
                    var columnBinding = headerClicked.Column.DisplayMemberBinding as Binding;
                    var sortBy = columnBinding?.Path.Path ?? headerClicked.Column.Header as string;
                    Sort(sortBy, direction);
                    if (direction == ListSortDirection.Ascending)
                    {
                        headerClicked.Column.HeaderTemplate = Resources["HeaderTemplateArrowUp"] as DataTemplate;
                    }
                    else
                    {
                        headerClicked.Column.HeaderTemplate = Resources["HeaderTemplateArrowDown"] as DataTemplate;
                    }
                    if (lastHeaderClicked != null && lastHeaderClicked != headerClicked)
                    {
                        lastHeaderClicked.Column.HeaderTemplate = null;
                    }
                    lastHeaderClicked = headerClicked;
                    lastDirection = direction;
                }
            }
        }

        private void Sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView = CollectionViewSource.GetDefaultView(listView.ItemsSource);
            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }

    }
}
