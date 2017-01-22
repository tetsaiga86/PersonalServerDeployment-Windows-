using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Personal_Server
{
    class InputBox
    {
        //http://www.csharp-examples.net/inputbox/
        public static DialogResult inputBox(String title, String promptText, ref string username, ref string password)
        {
            Form form = new Form();
            Label usernameLabel = new Label();
            Label passwordLabel = new Label();
            TextBox usernameTxtBx = new TextBox();
            TextBox passwordTxtBx = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            usernameLabel.Text = promptText;
            passwordLabel.Text = "Password:";
            usernameTxtBx.Text = username;
            usernameTxtBx.TextAlign = HorizontalAlignment.Center;
            passwordTxtBx.Text = password;
            passwordTxtBx.TextAlign = HorizontalAlignment.Center;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            usernameLabel.SetBounds(45, 20, 180, 13);
            passwordLabel.SetBounds(196, 20, 180, 13);
            usernameTxtBx.SetBounds(25, 36, 200, 20);
            passwordTxtBx.SetBounds(170, 36, 200, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            usernameLabel.AutoSize = true;
            passwordLabel.AutoSize = true;
            usernameTxtBx.Anchor = usernameTxtBx.Anchor | AnchorStyles.Right;
            passwordTxtBx.Anchor = passwordTxtBx.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { usernameLabel, passwordLabel, usernameTxtBx, passwordTxtBx, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, usernameLabel.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            username = usernameTxtBx.Text;
            password = passwordTxtBx.Text;
            return dialogResult;
        }
    }
}
