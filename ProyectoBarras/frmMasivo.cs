using BarcodeLib;
using iTextSharp.text;
using iTextSharp.text.pdf;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using ProyectoBarras.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarras
{
    public partial class frmMasivo : Form
    {
        private static bool permitir_carga = false;
        private static int total_productos = 0;

        private static string rutaguardado = "";
        private static int valorCodigo = -1;
        private static int verticalDocumento = -1;

        public frmMasivo()
        {
            InitializeComponent();
        }

        private void frmMasivo_Load(object sender, EventArgs e)
        {
            lblresumen.Text = "";

            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 1, Texto = "UPCA" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 2, Texto = "UPCE" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 3, Texto = "UPC_SUPPLEMENTAL_2DIGIT" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 4, Texto = "UPC_SUPPLEMENTAL_5DIGIT" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 5, Texto = "EAN13" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 6, Texto = "EAN8" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 7, Texto = "Interleaved2of5" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 8, Texto = "Standard2of5" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 9, Texto = "Industrial2of5" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 10, Texto = "CODE39" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 11, Texto = "CODE39Extended" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 12, Texto = "CODE39_Mod43" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 13, Texto = "Codabar" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 14, Texto = "PostNet" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 15, Texto = "BOOKLAND" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 16, Texto = "ISBN" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 17, Texto = "JAN13" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 18, Texto = "MSI_Mod10" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 19, Texto = "MSI_2Mod10" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 20, Texto = "MSI_Mod11" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 21, Texto = "MSI_Mod11_Mod10" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 22, Texto = "Modified_Plessey" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 23, Texto = "CODE11" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 24, Texto = "USD8" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 25, Texto = "UCC12" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 26, Texto = "UCC13" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 27, Texto = "LOGMARS" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 28, Texto = "CODE128" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 29, Texto = "CODE128A" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 30, Texto = "CODE128B" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 31, Texto = "CODE128C" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 32, Texto = "ITF14" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 33, Texto = "CODE93" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 34, Texto = "TELEPEN" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 35, Texto = "FIM" });
            cbotipocodigo.Items.Add(new OpcionCombo() { Valor = 36, Texto = "PHARMACODE" });

            cbotipocodigo.DisplayMember = "Texto";
            cbotipocodigo.ValueMember = "Valor";
            cbotipocodigo.SelectedIndex = 27;

            cboorientacion.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Vertical" });
            cboorientacion.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Horizontal" });
            cboorientacion.DisplayMember = "Texto";
            cboorientacion.ValueMember = "Valor";
            cboorientacion.SelectedIndex = 0;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] array = Properties.Resources.PlantillaProducto;
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "PlantillaProductos.xlsx";
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(savefile.FileName, array.ToArray());
                    MessageBox.Show("Descarga Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {

                MessageBox.Show("Error al descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btncargar_Click(object sender, EventArgs e)
        {

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Excel Files|*.xlsx";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtarchivo.Text = oOpenFileDialog.FileName.ToString();

                try
                {
                    IWorkbook MiExcel = null;
                    FileStream fs = new FileStream(oOpenFileDialog.FileName, FileMode.Open, FileAccess.Read);

                    if (Path.GetExtension(oOpenFileDialog.FileName) == ".xlsx")
                    {
                        MiExcel = new XSSFWorkbook(fs);
                        ISheet hoja = MiExcel.GetSheetAt(0);

                        if (hoja != null)
                        {

                            string columnas = string.Empty;
                            if (hoja.GetRow(0).GetCell(0) != null)
                            {
                                if (hoja.GetRow(0).Cells[0].StringCellValue.ToString().ToLower() != "codigo")
                                    columnas += "No se encontró la columna \"Codigo\"\n";
                            }
                            else
                                columnas += "No se encontró la columna \"Codigo\"\n";

                            if (hoja.GetRow(0).GetCell(1) != null)
                            {
                                if (hoja.GetRow(0).Cells[1].StringCellValue.ToString().ToLower() != "descripcion")
                                    columnas += "No se encontró la columna \"Descripcion\"\n";
                            }
                            else
                                columnas += "No se encontró la columna \"Descripcion\"\n";



                            if (string.IsNullOrEmpty(columnas))
                            {
                                int cantidadfilas = hoja.LastRowNum;
                                total_productos = cantidadfilas;
                                lblresumen.Text = string.Format("{0} Producto(s) encontrado(s)", cantidadfilas.ToString());
                                permitir_carga = true;
                            }
                            else
                            {
                                MessageBox.Show(columnas, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                permitir_carga = false;
                                lblresumen.Text = "";
                            }


                        }
                        else
                        {
                            MessageBox.Show("No se encontro una hoja", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            permitir_carga = false;
                            lblresumen.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Archivo incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        permitir_carga = false;
                        lblresumen.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    permitir_carga = false;
                    lblresumen.Text = "";
                    txtarchivo.Text = "";
                }
            }
        }

        private void btngenerardocumento_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                if (permitir_carga)
                {
                    progressBar1.Maximum = total_productos;
                    progressBar1.Step = 1;
                    progressBar1.Value = 0;
                    valorCodigo = Convert.ToInt32(((OpcionCombo)cbotipocodigo.SelectedItem).Valor.ToString());
                    verticalDocumento = Convert.ToInt32(((OpcionCombo)cboorientacion.SelectedItem).Valor.ToString());
                    CheckForIllegalCrossThreadCalls = false;

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.pdf", "CodigosMasivos_" + DateTime.Now.ToString("ddMMyyyyhhmmss"));
                    savefile.Filter = "Pdf Files|*.pdf";

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        rutaguardado = savefile.FileName;
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                else {
                    MessageBox.Show("Cargue el archivo correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                MessageBox.Show("El proceso esta pendiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (permitir_carga)
            {
                if (txtarchivo.Text.Trim() != "")
                {
                    List<Producto> oListaProducto = new List<Producto>();
                    IWorkbook MiExcel = null;
                    FileStream fs = new FileStream(txtarchivo.Text, FileMode.Open, FileAccess.Read);
                    MiExcel = new XSSFWorkbook(fs);
                    ISheet hoja = MiExcel.GetSheetAt(0);

                    int numeroEtiquetas = hoja.LastRowNum;
                    int numeroEtiquetasOrigen = numeroEtiquetas;
                    numeroEtiquetas = (numeroEtiquetas % 3) > 0 ? (3 * totalFilas(numeroEtiquetas)) : numeroEtiquetas;


                    int valor = valorCodigo;
                    int vertical = verticalDocumento;
                    int widthImage = vertical == 0 ? 170 : 230;
                    int HeightImage = vertical == 0 ? 80 : 110;
                    int descripcionSpacingAfter = chkmostrardescripcion.Checked ? 5 : 8;
                    BaseColor descripcionBaseColor = chkmostrardescripcion.Checked ? BaseColor.BLACK : BaseColor.WHITE;
                    iTextSharp.text.Rectangle orientacionDocumento = vertical == 0 ? PageSize.A4 : PageSize.A4.Rotate();
                    float sizeFont = vertical == 0 ? 16 : 14;

                  

                    using (FileStream stream = new FileStream(rutaguardado, FileMode.Create))
                    {

                        //CONFIGURACION DE DOCUMENTO
                        Document pdfDoc = new Document(orientacionDocumento, 15, 15, 15, 15);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        PdfPTable table = new PdfPTable(3);
                        table.WidthPercentage = 100;

                        for (int row = 1; row <= numeroEtiquetas; row++)
                        {
                            PdfPCell celda = new PdfPCell();

                            if (row > numeroEtiquetasOrigen)
                            {
                                celda.AddElement(new Paragraph(""));
                            }
                            else {

                                if (hoja.GetRow(row) != null)
                                {
                                    IRow fila = hoja.GetRow(row);
                                    Producto oProducto = new Producto();
                                    try
                                    {
                                        oProducto = new Producto()
                                        {
                                            Codigo = fila.GetCell(0, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(0).StringCellValue.ToString() : "",
                                            Descripcion = fila.GetCell(1, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(1).StringCellValue.ToString() : "",
                                        };
                                    }
                                    catch
                                    {
                                        oProducto = null;
                                    }

                                    if (oProducto != null)
                                    {
                                        string descripcionProducto = chkmostrardescripcion.Checked ? oProducto.Descripcion : "";

                                        try
                                        {
                                            //CONFIGURACION DE ETIQUETA
                                            BarcodeLib.Barcode etiqueta = new BarcodeLib.Barcode();
                                            etiqueta.IncludeLabel = chkmostrarcodigo.Checked;
                                            etiqueta.AlternateLabel = oProducto.Codigo;
                                            etiqueta.LabelPosition = LabelPositions.BOTTOMCENTER;
                                            etiqueta.LabelFont = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, sizeFont, FontStyle.Regular);
                                            etiqueta.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
                                            var etiquetaImagen = etiqueta.Encode(((BarcodeLib.TYPE)valor), oProducto.Codigo, Color.Black, Color.White, 400, 100);


                                            Paragraph para = new Paragraph();
                                            para.Alignment = Element.ALIGN_CENTER;
                                            para.Font = FontFactory.GetFont("Webdings", 10, iTextSharp.text.Font.NORMAL, descripcionBaseColor);
                                            para.Add(descripcionProducto);
                                            para.SpacingAfter = descripcionSpacingAfter;
                                            celda.AddElement(para);


                                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(etiquetaImagen, System.Drawing.Imaging.ImageFormat.Png);
                                            img.ScaleToFit(widthImage, HeightImage);
                                            img.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                                            if (!chkmostrarcodigo.Checked)
                                                img.SpacingAfter = 7;

                                            celda.AddElement(img);
                                            celda.HorizontalAlignment = Element.ALIGN_CENTER;
                                        }
                                        catch {
                                            celda.AddElement(new Paragraph(""));
                                        }
                                    }

                                    backgroundWorker1.ReportProgress(row);
                                }

                            }
                            table.AddCell(celda);

                        }
                        
                        pdfDoc.Add(table);

                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        progressBar1.Value = 0;
                        rutaguardado = "";
                        valorCodigo = -1;
                        verticalDocumento = -1;
                    }

                    
                }


            }
            else
            {
                MessageBox.Show("Cargue el archivo correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int totalFilas(int cantidad)
        {

            int numeroEtiquetas = cantidad;
            int numeroColumna = 1;
            int numeroFila = 1;

            for (int i = 1; i <= numeroEtiquetas; i++)
            {
                if (numeroColumna == 3)
                {
                    numeroFila++;
                    numeroColumna = 1;
                }
                else
                {
                    numeroColumna++;
                }
            }

            return numeroFila;
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            permitir_carga = false;
            lblresumen.Text = "";
            txtarchivo.Text = "";
            rutaguardado = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btngenerarimagen_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.IsBusy != true)
            {
                if (permitir_carga)
                {
                    progressBar1.Maximum = total_productos;
                    progressBar1.Step = 1;
                    progressBar1.Value = 0;
                    valorCodigo = Convert.ToInt32(((OpcionCombo)cbotipocodigo.SelectedItem).Valor.ToString());
                    verticalDocumento = Convert.ToInt32(((OpcionCombo)cboorientacion.SelectedItem).Valor.ToString());
                    CheckForIllegalCrossThreadCalls = false;

                    var folderBrowserDialog1 = new FolderBrowserDialog();

                    // Show the FolderBrowserDialog.
                    DialogResult result = folderBrowserDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        rutaguardado = folderBrowserDialog1.SelectedPath;
                        backgroundWorker2.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Cargue el archivo correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("El proceso esta pendiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (permitir_carga)
            {
                if (txtarchivo.Text.Trim() != "")
                {
                    IWorkbook MiExcel = null;
                    FileStream fs = new FileStream(txtarchivo.Text, FileMode.Open, FileAccess.Read);
                    MiExcel = new XSSFWorkbook(fs);
                    ISheet hoja = MiExcel.GetSheetAt(0);

                    int numeroEtiquetas = hoja.LastRowNum;
                    int valor = valorCodigo;

                    
                    for (int row = 1; row <= numeroEtiquetas; row++)
                    {
                        if (hoja.GetRow(row) != null)
                        {
                            IRow fila = hoja.GetRow(row);
                            Producto oProducto = new Producto();
                            try
                            {
                                oProducto = new Producto()
                                {
                                    Codigo = fila.GetCell(0, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(0).StringCellValue.ToString() : "",
                                    Descripcion = fila.GetCell(1, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(1).StringCellValue.ToString() : "",
                                };
                            }
                            catch
                            {
                                oProducto = null;
                            }

                            if (oProducto != null)
                            {
                                try
                                {
                                    //CONFIGURACION DE ETIQUETA
                                    using (BarcodeLib.Barcode etiqueta = new BarcodeLib.Barcode())
                                    {
                                        etiqueta.IncludeLabel = chkmostrarcodigo.Checked;
                                        etiqueta.AlternateLabel = oProducto.Codigo;
                                        etiqueta.LabelPosition = LabelPositions.BOTTOMCENTER;
                                        etiqueta.LabelFont = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, 16, FontStyle.Regular);
                                        etiqueta.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
                                        var etiquetaImagen = etiqueta.Encode(((BarcodeLib.TYPE)valor), oProducto.Codigo, Color.Black, Color.White, 400, 100);
                                  

                                        Bitmap titulo = ConvertirBitmap.convertirTextoImagen(oProducto.Descripcion);
                                        int width = Math.Max((chkmostrardescripcion.Checked ? titulo.Width : 0),etiquetaImagen.Width);
                                        int height = (chkmostrardescripcion.Checked ? titulo.Height : 0) +  etiquetaImagen.Height;

                                        Bitmap img3 = new Bitmap(width, height);
                                        Graphics g = Graphics.FromImage(img3);
                                        if(chkmostrardescripcion.Checked)
                                            g.DrawImage(titulo, new Point(0, 0));

                                        g.DrawImage(etiquetaImagen, new Point(0, (chkmostrardescripcion.Checked ? titulo.Height : 0)));
                                        
                                        img3.Save(string.Format("{0}/{1}.png", rutaguardado, oProducto.Codigo), System.Drawing.Imaging.ImageFormat.Png);
                                        img3.Dispose();

                                        g.Dispose();
                                        titulo.Dispose();
                                        etiquetaImagen.Dispose();
                                        etiqueta.Dispose();

                                    }
                                }
                                catch
                                {
                                }
                            }

                            backgroundWorker2.ReportProgress(row);
                        }

                    }

                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    progressBar1.Value = 0;
                    rutaguardado = "";
                    valorCodigo = -1;
                    verticalDocumento = -1;
                }
            }
            else
            {
                MessageBox.Show("Cargue el archivo correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            permitir_carga = false;
            lblresumen.Text = "";
            txtarchivo.Text = "";
            rutaguardado = "";
        }
    }
}
