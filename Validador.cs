using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorFE
{
    public partial class Validador : Form
    {
        public Validador()
        {
            InitializeComponent();
            txt_xml.ScrollBars = ScrollBars.Vertical;
        }

        private void bt_validador_Click(object sender, EventArgs e)
        {
            string salida="";
            Chilkat.XmlDSig dsig = new Chilkat.XmlDSig();
            bool success = dsig.LoadSignature(txt_xml.Text);

            int numSignatures = dsig.NumSignatures;
            int i = 0;
            while (i < numSignatures)
            {
                dsig.Selector = i;

                bool bVerifyRefDigests = false;
                bool bSignatureVerified = dsig.VerifySignature(bVerifyRefDigests);
                if (bSignatureVerified == true)
                {
                    salida = "Signature " + Convert.ToString(i + 1) + "verified";
                }
                else
                {
                    salida = "Signature " + Convert.ToString(i + 1) + "invalid";
                }

                // Check each of the reference digests separately..
                int numRefDigests = dsig.NumReferences;
                int j = 0;
                while (j < numRefDigests)
                {
                    bool bDigestVerified = dsig.VerifyReferenceDigest(j);
                    salida += "\r\nreference digest " + Convert.ToString(j + 1) + " verified = " + Convert.ToString(bDigestVerified);
                    if (bDigestVerified == false)
                    {
                        salida += "\r\nreference digest fail reason: " + Convert.ToString(dsig.RefFailReason);
                    }
                    j = j + 1;
                }
                i = i + 1;
            }
            MessageBox.Show(salida, "Verificación de XML", MessageBoxButtons.OK);
        }
    }
}
