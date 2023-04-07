#pragma warning disable CS8767 // 參數類型中參考型別是否可為 NULL 的情況，與隱含實作的成員不相符 (可能的原因是屬性可為 NULL )。

using System.Collections;

namespace Wcat_Index_Decide
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
