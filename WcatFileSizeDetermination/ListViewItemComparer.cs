using System.Collections;
using System.Windows.Forms;

namespace WcatFileSizeDetermination
{
    public class ListViewItemComparer : IComparer
	{
		public ListViewItemComparer()
		{
			col = 0;
			order = SortOrder.Ascending;
		}

		public ListViewItemComparer(int colum, SortOrder order)
		{
			this.order = order;
			col = colum;
		}

		public int Compare(object x, object y)
		{
			int num = 0;
			if (order == SortOrder.Descending)
			{
				if (order == SortOrder.Descending)
				{
					int num2 = int.Parse(((ListViewItem)x).SubItems[col].Text);
					int num3 = int.Parse(((ListViewItem)y).SubItems[col].Text);
					if (num2 > num3)
					{
					}
					if (num2 < num3)
					{
						num = -1;
					}
					else
					{
						num = 0;
					}
					num *= -1;
				}
				return num;
			}
			decimal d = int.Parse(((ListViewItem)x).SubItems[col].Text);
			decimal d2 = int.Parse(((ListViewItem)y).SubItems[col].Text);
			if (d2 > d && order != SortOrder.Descending)
			{
				return -1;
			}
			if (d2 < d)
			{
				return 1;
			}
			return 0;
		}

		private int col;

		private SortOrder order;
	}
}
