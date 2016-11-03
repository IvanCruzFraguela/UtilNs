using System;
using System.Windows.Forms;

namespace Utilns.Forms{
    public static class FMemo
    {
        //todo: Pasar FMemo a utils
        private static Form form;
        public static void Show(string s)
        {
            form = new Form();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Width * 0.8);
            form.Height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Height * 0.8);
            TextBox t = new TextBox();
            t.Parent = form;
            t.Multiline = true;
            t.Dock = DockStyle.Fill;
            t.ScrollBars = ScrollBars.Both;
            t.Font = new System.Drawing.Font("Courier new", 12);
            Panel p = new Panel();
            p.Parent = form;
            p.Dock = DockStyle.Bottom;
            Button b = new Button();
            b.Parent = p;
            b.AutoSize = true;
            b.Text = "Salir";
            b.Left = (b.Parent.Width / 2) - (b.Width / 2);
            b.Top = 1;
            p.Height = b.Height + 2;

            t.Text = s;
            t.Focus();
            form.CancelButton = b;
            form.ShowDialog();
        }
    }
}
