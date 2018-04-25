using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csmdfreader
{
    public partial class FrmMDF : Form
    {
        public FrmMDF()
        {
            InitializeComponent();
        }

        private void btnMDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "MDF File (*.mdf, *.dat) | *.mdf; *.dat";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                string file = diag.FileName;
                FileStream stream = new FileStream(file, FileMode.Open);
                int size = Marshal.SizeOf(typeof(IDBLOCK));
                byte[] bytes = new byte[size];
                stream.Read(bytes, 0, size);
                IntPtr buffer = Marshal.AllocHGlobal(size);
                Marshal.Copy(bytes, 0, buffer, size);
                IDBLOCK idBlock = (IDBLOCK)Marshal.PtrToStructure(buffer, typeof(IDBLOCK));
                stream.Close();
                txtMDF.AppendText(file+"\r\n");
                txtMDF.AppendText(idBlock.ToString());
                txtMDF.AppendText("\r\n");
            }
        }
    }
}
