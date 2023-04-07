#pragma warning disable CS8767 // 參數類型中參考型別是否可為 NULL 的情況，與隱含實作的成員不相符 (可能的原因是屬性可為 NULL )。

using System.Collections;

namespace Wcat_Index_Decide
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
			decimal num = Convert.ToDecimal(((ListViewItem)x).SubItems[col].Tag);
			decimal num2 = Convert.ToDecimal(((ListViewItem)y).SubItems[col].Tag);
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
