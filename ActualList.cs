using System.Collections.Generic;

namespace IvanCruz.Utilns {
    public class CActualList<T> : List<T> {
		public T Actual { get; set; }
		public new void Add(T item) {
			base.Add(item);
			this.Actual = item;
		}
		/// <summary>
		/// AddR AddReturning. Return de item added
		/// </summary>
		/// <param name="item">Item to Add</param>
		/// <returns></returns>
		public T AddR(T item) {
			this.Add(item);
			return item;
		}
	}
}
