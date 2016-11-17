using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilns.UI {
    public class ComboItem {
        int id { get; set; }
        string nomb { get; set; }

        public ComboItem(int id, string nomb) {
            this.id = id;
            this.nomb = nomb;
        }
    }
}
