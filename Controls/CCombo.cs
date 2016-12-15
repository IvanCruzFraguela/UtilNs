using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilns.Controls {
    public class ComboItem {
        public int Value { get; set; }
        public string Text { get; set; }
        public ComboItem(int id, string nomb) {
            this.Value = id;
            this.Text = nomb;
        }
    }
    public class CCombo : ComboBox {
        public CCombo() : base() {
            this.DisplayMember = "Text";
            this.ValueMember = "Value";
        }
        public ComboItem Add(ComboItem item) {
            this.Items.Add(item);
            return item;
        }
        public ComboItem Add(int value, string text) {
            return this.Add(new ComboItem(value, text));
        }
        public int? Value {
            get {
                if (this.SelectedItem == null) {
                    return null;
                }
                return (this.SelectedItem as ComboItem).Value;
            }
            set {
                if (value.HasValue) {
                    int i = 0;
                    while (i < this.Items.Count) {
                        if ((this.Items[i] as ComboItem).Value == value) {
                            this.SelectedItem = this.Items[i];
                            return;
                        }
                        i++;
                    }
                    throw new ArgumentException("El valor " + value.ToString() + " no se encuentra entre los valores del Combo");
                }else {
                    this.SelectedValue = null;
                }
            }
        }
    }
}
