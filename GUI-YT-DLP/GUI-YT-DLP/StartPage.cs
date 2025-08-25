using System.Diagnostics;
using System.IO;
namespace GUI_YT_DLP
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }


        public string EncontrarYTDLP() {
            string ruta = Directory.GetCurrentDirectory();

            while (ruta != null) 
            {
                
                foreach (string subcarpeta in Directory.EnumerateDirectories(ruta))
                {
                    if (Path.GetFileName(subcarpeta).Equals("yt-dlp", StringComparison.OrdinalIgnoreCase))
                    {
                        return subcarpeta; 
                    }
                }

                
                ruta = Directory.GetParent(ruta)?.FullName;
            }

            
            return null;

        }


        public void DescargarMusica(string rutaDeDescarga)
        {


            string rutaFinal = EncontrarYTDLP();
            var startDownload = new ProcessStartInfo("cmd.exe") {
                Arguments=$"/k yt-dlp -x --audio-format mp3 -P \"{rutaDeDescarga}\" {txtUrl.Text}",
                UseShellExecute = false,
                WorkingDirectory = rutaFinal
            };
            Process.Start(startDownload);
        }

        public void SeleccionarCarpeta()
        {

            

            FolderBrowserDialog listaCarpetas = new FolderBrowserDialog();
            if (listaCarpetas.ShowDialog() == DialogResult.OK)
            {
                txtRutaDeDescarga.Text = listaCarpetas.SelectedPath;
            }
            

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            DescargarMusica(txtRutaDeDescarga.Text);
        }

        private void btnAbrirCarpetas_Click(object sender, EventArgs e)
        {
            SeleccionarCarpeta();
        }
    }
}
