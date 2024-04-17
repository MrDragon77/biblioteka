using biblaoteka.Properties;
using System.Text;
using System.Reflection;


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
            String line;
            String[] perms;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "MyCompany.MyProduct.MyFile.txt";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                try
            {
                StreamReader sr = new StreamReader(Resources.UserNamesXPasswords);
                Console.WriteLine("here");
                line = sr.ReadLine();
                Console.WriteLine("or here");
                perms = line.Split(' ');
                Console.WriteLine("or or here");
                if (UserNameTextBox.Text == perms[0] && PasswordTextBox.Text == perms[1])
                {
                    throw new Exception("success");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Authorization successful");
            }
        }
    }
}