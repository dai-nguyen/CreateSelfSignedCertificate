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
            btnCreateText.Enabled = false;
            btnCopy.Enabled = false;

            btnCreate.Click += btnCreate_Click;
            txtName.LostFocus += TxtName_LostFocus;
            numYear.LostFocus += NumYear_LostFocus;
            txtPassword.LostFocus += TxtPassword_LostFocus;
            numYear.Value = 2;
            radioKeyEncipherment.Checked = true;

            btnCreateText.Click += BtnCreateText_Click;

            txtCert.ReadOnly = true;
            btnCopy.Click += BtnCopy_Click;
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

            btnCreateText.Enabled = btnCreate.Enabled;
            btnCopy.Enabled = !string.IsNullOrEmpty(txtCert.Text);
        }

        private byte[] CreateCertificate()
        {
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

                if (radioKeyEncipherment.Checked)
                {
                    request
                        .CertificateExtensions
                        .Add(new X509KeyUsageExtension(X509KeyUsageFlags.KeyEncipherment, critical: true));
                }
                else if (radioDigitalSignature.Checked)
                {
                    request
                        .CertificateExtensions
                        .Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature, critical: true));
                }

                var certificate = request.CreateSelfSigned(DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddYears(year));

                return certificate.Export(X509ContentType.Pfx, password);
            }
        }

        private void btnCreate_Click(object? sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "pfx files (*.pfx)|*.pfx";                
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                var data = CreateCertificate();

                File.WriteAllBytes(dialog.FileName, data);
            }
                
        }

        private void BtnCreateText_Click(object? sender, EventArgs e)
        {
            var data = CreateCertificate();
            txtCert.Text = Convert.ToBase64String(data);
            btnCopy.Enabled = !string.IsNullOrEmpty(txtCert.Text);
        }

        private void BtnCopy_Click(object? sender, EventArgs e)
        {            
            Clipboard.SetText(txtCert.Text);
        }
    }
}