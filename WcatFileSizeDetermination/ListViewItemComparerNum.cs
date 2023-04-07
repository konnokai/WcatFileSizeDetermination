using System;
using System.Collections;
using System.Windows.Forms;

namespace WcatFileSizeDetermination
{
	public class ListViewItemComparerNum : IComparer
	{
		public ListViewItemComparerNum()
		{
			col = 0;
		}

		public ListViewItemComparerNum(int column, bool sort)
		{
			col = column;
			sort_b = sort;
		}

		public int Compare(object x, object y)
		{
			decimal num = Convert.ToDecimal(((ListViewItem)x).SubItems[col].Text);
			decimal num2 = Convert.ToDecimal(((ListViewItem)y).SubItems[col].Text);
			if (sort_b)
			{
				return decimal.Compare(num, num2);
			}
			return decimal.Compare(num2, num);
		}

		public bool sort_b;

		public SortOrder order = SortOrder.Ascending;

		private int col;
	}
}
