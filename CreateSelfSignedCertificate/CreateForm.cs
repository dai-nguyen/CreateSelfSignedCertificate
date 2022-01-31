using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace CreateSelfSignedCertificate
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();

            btnCreate.Enabled = false;
            btnCreate.Click += btnCreate_Click;
            txtName.LostFocus += TxtName_LostFocus;
            numYear.LostFocus += NumYear_LostFocus;
            txtPassword.LostFocus += TxtPassword_LostFocus;
            numYear.Value = 2;
        }

        private void TxtPassword_LostFocus(object? sender, EventArgs e)
        {
            ValidateCreateBtn();
        }

        private void NumYear_LostFocus(object? sender, EventArgs e)
        {
            ValidateCreateBtn();
        }

        private void TxtName_LostFocus(object? sender, EventArgs e)
        {
            ValidateCreateBtn();
        }

        void ValidateCreateBtn()
        {            
            btnCreate.Enabled = !string.IsNullOrEmpty(txtName.Text)
                && !string.IsNullOrWhiteSpace(txtName.Text)
                && numYear.Value > 0
                && !string.IsNullOrEmpty(txtPassword.Text)
                && !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private void btnCreate_Click(object? sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "pfx files (*.pfx)|*.pfx";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                using (var algorithm = RSA.Create(keySizeInBits: 2048))
                {
                    string name = $"CN={txtName.Text.Trim()}";
                    int year = (int)numYear.Value;
                    string password = txtPassword.Text.Trim();

                    var subject = new X500DistinguishedName(name);

                    var request = new CertificateRequest(
                        subject,
                        algorithm,
                        HashAlgorithmName.SHA256,
                        RSASignaturePadding.Pkcs1);

                    request
                        .CertificateExtensions
                        .Add(new X509KeyUsageExtension(X509KeyUsageFlags.KeyEncipherment, critical: true));

                    var certificate = request.CreateSelfSigned(DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddYears(year));

                    var data = certificate.Export(X509ContentType.Pfx, password);

                    File.WriteAllBytes(dialog.FileName, data);
                }
            }
                
        }
    }
}