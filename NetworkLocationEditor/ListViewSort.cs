using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NetworkLocationEditor
{
    class ListViewSort : IComparer
    {
        private int _column;
        private bool _desc;
        public ListViewSort()
        {
            _column = 0;
        }
        public ListViewSort(int column, bool desc)
        {
            _column = column;
            _desc = desc;
        }
        public int Compare(object x, object y)
        {
            int flag = String.Compare(((ListViewItem)x).SubItems[_column].Text, ((ListViewItem)y).SubItems[_column].Text);
            if (_desc)
            {
                return -flag;
            }
            else
            {
                return flag;
            }
        }
    }
}
