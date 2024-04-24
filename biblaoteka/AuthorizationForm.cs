using biblaoteka.Properties;
using System.Text;
using System.Reflection;
using System.Diagnostics;

namespace biblaoteka
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        public static string CreateMD5(string s)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var encoding = Encoding.ASCII;
                var data = encoding.GetBytes(s);

                Span<byte> hashBytes = stackalloc byte[16];
                md5.TryComputeHash(data, hashBytes, out int written);
                if (written != hashBytes.Length)
                    throw new OverflowException();


                Span<char> stringBuffer = stackalloc char[32];
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashBytes[i].TryFormat(stringBuffer.Slice(2 * i), out _, "x2");
                }
                return new string(stringBuffer);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String[] perms;
            try
            {
                StreamReader sr = new StreamReader("UserNamesXPasswords.txt");
                while (!sr.EndOfStream)
                {
                    perms = sr.ReadLine().Split(' ');
                    Debug.WriteLine(CreateMD5(PasswordTextBox.Text));
                    if (UserNameTextBox.Text == perms[0] && CreateMD5(PasswordTextBox.Text) == perms[1])
                    {
                        Debug.WriteLine("success, loading main form");
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        sr.Close();
                        return;
                    }
                }
                sr.Close();
                Debug.WriteLine("wrong, still that form");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}