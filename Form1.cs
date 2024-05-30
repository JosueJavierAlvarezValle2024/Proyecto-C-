using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using ClosedXML.Excel;


namespace Proyecto_C_
{
    public partial class Form1 : Form
    {
        private BasicBasket basket;
        private int SelectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            basket = new BasicBasket();

            BasicBasket.WelcomeMessage(); // METODO ESTATICO
        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstvProducts.SelectedIndices.Count > 0)
            {
                basket.DeleteProduct(lstvProducts.SelectedIndices[0]);
                UpdateProductList();
                UpdateTotal();
            }
        }

        private void lstvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvProducts.SelectedIndices.Count > 0)
            {
                SelectedIndex = lstvProducts.SelectedIndices[0];
                Product producto = basket.GetProducts()[SelectedIndex];
                txtName.Text = producto.Name;
                txtPrice.Text = producto.Price.ToString();
                btnAdd.Text = "Edit";
            }
        }

        private void UpdateProductList()
        {
            lstvProducts.Items.Clear();
            foreach (var product in basket.GetProducts())
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.AddedDate.ToString()); 
                lstvProducts.Items.Add(item);
            }
        }

        private void UpdateTotal()
        {
            lblTotal.Text = $"TOTAL: {basket.CalculateTotal():C}";
        }

        private void CleanupFields()
        {
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a product name.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtOrderName.Text))
                {
                    MessageBox.Show("Please enter an order name.");
                    return;
                }

                string name = txtName.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                Product product = new Product(name, price);

                

                if (SelectedIndex >= 0)
                {
                    btnAdd.Text = "Add";
                    SelectedIndex = -1;
                }
                else
                {
                    basket.AddProduct(product);
                }

                UpdateProductList();
                UpdateTotal();
                CleanupFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid price.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (lstvProducts.SelectedIndices.Count > 0)
            {
                basket.DeleteProduct(lstvProducts.SelectedIndices[0]);
                UpdateProductList();
                UpdateTotal();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDocx_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderName.Text))
            {
                MessageBox.Show("Please enter an order name.", "Missing Order Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Document|*.docx";
                saveFileDialog.Title = "Save products list";
                saveFileDialog.FileName = "Ticket.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                        {
                            MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                            mainPart.Document = new Document();

                            Body body = new Body();

                            DateTime creationDateTime = DateCreatedNow.Value;
                            Paragraph datePara = new Paragraph(new Run(new Text("Creation date and time: " + creationDateTime.ToString("g"))));
                            datePara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Right });
                            body.Append(datePara);

                            Paragraph orderNamePara = new Paragraph(new Run(new Text("Order Name: " + txtOrderName.Text)));
                            orderNamePara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                            body.Append(orderNamePara);

                            Paragraph titlePara = new Paragraph(new Run(new Text("List of Products")));
                            titlePara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                            body.Append(titlePara);

                            foreach (ListViewItem item in lstvProducts.Items)
                            {
                                Paragraph para = new Paragraph();
                                Run run = new Run();

                                string line = item.Text;
                                if (item.SubItems.Count > 1)
                                {
                                    line += " - " + item.SubItems[1].Text;
                                }

                                Text text = new Text(line);
                                run.Append(text);
                                para.Append(run);
                                body.Append(para);
                            }

                            Paragraph totalPara = new Paragraph(new Run(new Text(" " + lblTotal.Text)));
                            totalPara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Right });
                            body.Append(totalPara);

                            
                            Paragraph countPara = new Paragraph(new Run(new Text($"Number of products: {basket.Count}")));
                            countPara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Left });
                            body.Append(countPara);

                            mainPart.Document.Append(body);
                            mainPart.Document.Save();
                        }

                        MessageBox.Show("Thanks for your order", "Successful order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating document: " + ex.Message);
                    }
                }
            }
        }
        

        private void btnTxt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderName.Text))
            {
                MessageBox.Show("Please enter an order name.", "Missing Order Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.Title = "Save products list";
                saveFileDialog.FileName = "Ticket.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            DateTime creationDateTime = DateCreatedNow.Value;
                            writer.WriteLine("Creation date and time: " + creationDateTime.ToString("g"));
                            writer.WriteLine();


                            writer.WriteLine("Order Name: " + txtOrderName.Text);
                            writer.WriteLine();

                            writer.WriteLine("List of Products");
                            writer.WriteLine();

                            foreach (ListViewItem item in lstvProducts.Items)
                            {
                                string line = item.Text;
                                if (item.SubItems.Count > 1)
                                {
                                    line += " - " + item.SubItems[1].Text;
                                }
                                writer.WriteLine(line);
                            }


                            writer.WriteLine();
                            writer.WriteLine(" " + lblTotal.Text);
                            writer.WriteLine($"Number of products: {basket.Count}");
                        }

                        MessageBox.Show("Thanks for your order", "Successful order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating document: " + ex.Message);
                    }
                }
            }
        }

        private void btnXslx_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderName.Text))
            {
                MessageBox.Show("Please enter an order name.", "Missing Order Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel File|*.xlsx";
                saveFileDialog.Title = "Save products list";
                saveFileDialog.FileName = "Ticket.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Products");

                            DateTime creationDateTime = DateCreatedNow.Value;
                            worksheet.Cell("A1").Value = "Creation date and time:";
                            worksheet.Cell("B1").Value = creationDateTime.ToString("g");

                            worksheet.Cell("A2").Value = "Order Name:";
                            worksheet.Cell("B2").Value = txtOrderName.Text;

                            worksheet.Cell("A4").Value = "List of Products";

                            int row = 5;
                            foreach (ListViewItem item in lstvProducts.Items)
                            {
                                string productName = item.Text;
                                string price = item.SubItems.Count > 1 ? item.SubItems[1].Text : "";

                                worksheet.Cell("A" + row).Value = productName;
                                worksheet.Cell("B" + row).Value = price;

                                row++;
                            }

                            worksheet.Cell("A" + row).Value = " ";
                            worksheet.Cell("B" + row).Value = lblTotal.Text;

                            
                            worksheet.Cell("A" + (row + 1)).Value = "Number of products:";
                            worksheet.Cell("B" + (row + 1)).Value = basket.Count;

                            worksheet.Column("A").Width = 27;

                            workbook.SaveAs(filePath);
                        }

                        MessageBox.Show("Thanks for your order", "Successful order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating Excel document: " + ex.Message);
                    }
                }
            }
        }

        
    }
}






