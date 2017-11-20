using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Util.Controls {
    public class CComboItem {
        public int Value { get; set; }
        public string Text { get; set; }
        public CComboItem(int id, string nomb) {
            this.Value = id;
            this.Text = nomb;
        }
    }
    public class CCombo : ComboBox {
        public CCombo() : base() {
            Init(this);
        }
        public CComboItem Add(CComboItem item) {
            this.Items.Add(item);
            return item;
        }
        public CComboItem Add(int value, string text) {
            return this.Add(new CComboItem(value, text));
        }
        public int? Value {
            get {
                return GetComboItemValue(this);
            }
            set {
                if (value.HasValue) {
                    int i = 0;
                    while (i < this.Items.Count) {
                        if ((this.Items[i] as CComboItem).Value == value) {
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
        public static int? GetComboItemValue(ComboBox comboBox) {
            if (comboBox.SelectedItem == null) {
                return null;
            }
            return (comboBox.SelectedItem as CComboItem).Value;
        }
        public static void SetComboItemValue(ComboBox comboBox,int? value) {
                if (value.HasValue) {
                    int i = 0;
                    while (i < comboBox.Items.Count) {
                        if ((comboBox.Items[i] as CComboItem).Value == value) {
                            comboBox.SelectedItem = comboBox.Items[i];
                            return;
                        }
                        i++;
                    }
                    throw new ArgumentException("El valor " + value.ToString() + " no se encuentra entre los valores del Combo");
                }else {
                    comboBox.SelectedValue = null;
                }
        }
        public static void Init(ComboBox comboBox) {
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

		public void SetValidValue() {
			if(Items.Count == 0) {
				throw new NoItemsException("No hay valores entre los que elegir uno válido");
			}else {
				this.Value = (this.Items[0] as CComboItem).Value;
			}

		}
	}

	[Serializable]
	internal class NoItemsException : Exception {
		public NoItemsException() {
		}

		public NoItemsException(string message) : base(message) {
		}

		public NoItemsException(string message, Exception innerException) : base(message, innerException) {
		}

		protected NoItemsException(SerializationInfo info, StreamingContext context) : base(info, context) {
		}
	}
}
