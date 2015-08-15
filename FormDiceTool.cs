using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace DiceTool
{
    /// <summary>
    /// 
    /// </summary>
    internal partial class FormDiceTool : Form
    {
        /// <summary>
        /// 
        /// </summary>
        internal FormDiceTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDiceTool_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDiceTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FileDialogSaveDiceTool.Tag == null && ListViewRolls.Items.Count > 0)
            {
                var MsgResult = MessageBox.Show("Voulez-vous sauvegarder avant de quitter?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (MsgResult == DialogResult.Yes)
                {
                    FileDialogSaveDiceTool.Tag = "Close";
                    if (FileDialogSaveDiceTool.ShowDialog() != DialogResult.OK)
                    {
                        FileDialogSaveDiceTool.Tag = null;
                    }
                }
                else if (MsgResult == DialogResult.No)
                {
                    return;
                }
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRollDice_Click(object sender, EventArgs e)
        {
            var DiceType = Convert.ToInt16(((Button)sender).Text);
            var DiceRandom = new Random();
            var DiceValue = DiceRandom.Next(DiceType) + 1;
            var Comment = TextBoxSpace.Text;
            var DiceLvi = new ListViewItem();
            DiceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Ticks", Text = " " + DateTime.Now.Ticks });
            DiceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "DateTime", Text = DateTime.Now.ToString() });
            DiceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Dice", Text = DiceType.ToString() });
            DiceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Roll", Text = DiceValue.ToString() });
            DiceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Comment", Text = !string.IsNullOrEmpty(Comment) ? Comment : "-" });
            switch (DiceType)
            {
                case 2:
                    if (DiceValue == DiceType)
                    {
                        DiceLvi.ImageIndex = 4;
                    }
                    else
                    {
                        DiceLvi.ImageIndex = 0;
                    }
                    break;
                case 4:
                    if (DiceValue == DiceType)
                    {
                        DiceLvi.ImageIndex = 4;
                    }
                    else if (DiceValue > 2)
                    {
                        DiceLvi.ImageIndex = 3;
                    }
                    else if (DiceValue > 1)
                    {
                        DiceLvi.ImageIndex = 2;
                    }
                    else
                    {
                        DiceLvi.ImageIndex = 0;
                    }
                    break;
                case 6:
                    if (DiceValue == DiceType)
                    {
                        DiceLvi.ImageIndex = 4;
                    }
                    else if (DiceValue > 3)
                    {
                        DiceLvi.ImageIndex = 3;
                    }
                    else if (DiceValue > 1)
                    {
                        DiceLvi.ImageIndex = 1;
                    }
                    else
                    {
                        DiceLvi.ImageIndex = 0;
                    }
                    break;
                case 8:
                    if (DiceValue == DiceType)
                    {
                        DiceLvi.ImageIndex = 4;
                    }
                    else if (DiceValue > 5)
                    {
                        DiceLvi.ImageIndex = 3;
                    }
                    else if (DiceValue > 3)
                    {
                        DiceLvi.ImageIndex = 2;
                    }
                    else if (DiceValue > 1)
                    {
                        DiceLvi.ImageIndex = 1;
                    }
                    else
                    {
                        DiceLvi.ImageIndex = 0;
                    }
                    break;
                case 10:
                    if (DiceValue == DiceType)
                    {
                        DiceLvi.ImageIndex = 4;
                    }
                    else if (DiceValue > 7)
                    {
                        DiceLvi.ImageIndex = 3;
                    }
                    else if (DiceValue > 4)
                    {
                        DiceLvi.ImageIndex = 2;
                    }
                    else if (DiceValue > 1)
                    {
                        DiceLvi.ImageIndex = 1;
                    }
                    else
                    {
                        DiceLvi.ImageIndex = 0;
                    }
                    break;
                case 20:
                    if (DiceValue == DiceType)
                    {
                        DiceLvi.ImageIndex = 4;
                    }
                    else if (DiceValue > 13)
                    {
                        DiceLvi.ImageIndex = 3;
                    }
                    else if (DiceValue > 7)
                    {
                        DiceLvi.ImageIndex = 2;
                    }
                    else if (DiceValue > 1)
                    {
                        DiceLvi.ImageIndex = 1;
                    }
                    else
                    {
                        DiceLvi.ImageIndex = 0;
                    }
                    break;
            }
            ListViewRolls.Items.Add(DiceLvi);
            TextBoxSpace.Text = "";
            ListViewRolls.SelectedItems.Clear();
            DiceLvi.EnsureVisible();
            DiceLvi.Selected = true;
            FileDialogSaveDiceTool.Tag = null;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous certain de vouloir effacer le log?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewRolls.Items.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSpace_Click(object sender, EventArgs e)
        {
            var Comment = TextBoxSpace.Text;
            if (!string.IsNullOrEmpty(Comment))
            {
                var SpaceLvi = new ListViewItem();
                SpaceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Ticks", Text = " " + DateTime.Now.Ticks });
                SpaceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "DateTime", Text = DateTime.Now.ToString() });
                SpaceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Dice", Text =  "-"});
                SpaceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Roll", Text =  "-"});
                SpaceLvi.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Comment", Text = Comment });
                SpaceLvi.ImageIndex = 5;
                ListViewRolls.Items.Add(SpaceLvi);
                TextBoxSpace.Text = string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (ListViewRolls.Items.Count == 0 || MessageBox.Show("Le chargement d'une sauvegarde va effacer le log actuel?\n\nVoulez-vous continuer?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (FileDialogOpenDiceTool.ShowDialog() == DialogResult.OK)
                {
                    UseWaitCursor = true;
                    TableLayoutDiceTool.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileDialogOpenDiceTool_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                WorkerOpenDiceTool.RunWorkerAsync(new FileInfo(FileDialogOpenDiceTool.FileName));
            }
            catch (Exception)
            {
                throw new FileNotFoundException();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerOpenDiceTool_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                var FileToRead = (FileInfo)e.Argument;
                var Deserializer = new BinaryFormatter();
                Object ObjectDeserialized;
                using (var Stream = FileToRead.OpenRead())
                {
                    ObjectDeserialized = Deserializer.Deserialize(Stream);
                }
                e.Result = ObjectDeserialized;
            }
            catch (Exception Ex)
            {
                e.Result = Ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerOpenDiceTool_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            var Result = e.Result;
            if (Result != null && Result.GetType() == typeof(Exception))
            {
                MessageBox.Show("Erreur : " + ((Exception)Result).Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewRolls.Items.Clear();
                ListViewRolls.Items.AddRange((ListViewItem[])e.Result);
            }
            TableLayoutDiceTool.Enabled = true;
            UseWaitCursor = false;
            FileDialogSaveDiceTool.Tag = "Loaded";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            FileDialogSaveDiceTool.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileDialogSaveDiceTool_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UseWaitCursor = true;
            TableLayoutDiceTool.Enabled = false;
            try
            {
                var LviList = new List<ListViewItem>();
                foreach (ListViewItem Lvi in ListViewRolls.Items)
                {
                    LviList.Add((ListViewItem)Lvi.Clone());
                }
                WorkerSaveDiceTool.RunWorkerAsync(new KeyValuePair<ListViewItem[], FileInfo>(LviList.ToArray(), new FileInfo(FileDialogSaveDiceTool.FileName)));
            }
            catch (Exception)
            {
                throw new FileNotFoundException();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerSaveDiceTool_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                WorkerSaveDiceTool.ReportProgress(10);
                var Argument = (KeyValuePair<ListViewItem[], FileInfo>)e.Argument;
                WorkerSaveDiceTool.ReportProgress(20);
                var ObjectToSerialize = Argument.Key;
                WorkerSaveDiceTool.ReportProgress(30);
                var FileToSave = Argument.Value;
                WorkerSaveDiceTool.ReportProgress(40);
                if (FileToSave.Extension.Contains("dct"))
                {
                    WorkerSaveDiceTool.ReportProgress(50);
                    var Stream = new MemoryStream();
                    WorkerSaveDiceTool.ReportProgress(60);
                    var Serializer = new BinaryFormatter();
                    WorkerSaveDiceTool.ReportProgress(70);
                    Serializer.Serialize(Stream, ObjectToSerialize);
                    WorkerSaveDiceTool.ReportProgress(80);
                    using (var FileStream = FileToSave.OpenWrite())
                    {
                        FileStream.Write(Stream.GetBuffer(), 0, Stream.GetBuffer().Length);
                    }
                }
                if (FileToSave.Extension.Contains("csv"))
                {
                    var CsvSeperator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
                    WorkerSaveDiceTool.ReportProgress(80);
                    using (var FileWriter = new StreamWriter(FileToSave.FullName))
                    {
                        FileWriter.WriteLine("Face" + CsvSeperator + "Ticks" + CsvSeperator + "DateTime" + CsvSeperator + "Dice" + CsvSeperator + "Roll" + CsvSeperator + "Comment");
                        foreach (var Lvi in ObjectToSerialize)
                        {
                            var NewLine = string.Empty;
                            switch (Lvi.ImageIndex)
                            {
                                case 0:
                                    NewLine += ":'(" + CsvSeperator;
                                    break;
                                case 1:
                                    NewLine += ":-(" + CsvSeperator;
                                    break;
                                case 2:
                                    NewLine += ":-|" + CsvSeperator;
                                    break;
                                case 3:
                                    NewLine += ":-)" + CsvSeperator;
                                    break;
                                case 4:
                                    NewLine += "B-)" + CsvSeperator;
                                    break;
                                case 5:
                                    NewLine += "(i)" + CsvSeperator;
                                    break;
                            }
                            foreach (ListViewItem.ListViewSubItem SubItem in Lvi.SubItems)
                            {
                                NewLine += SubItem.Text.Trim() + CsvSeperator;
                            }
                            FileWriter.WriteLine(NewLine.TrimEnd(CsvSeperator.ToCharArray()));
                        }
                        FileWriter.Close();
                    }
                }
                WorkerSaveDiceTool.ReportProgress(100);
            }
            catch (Exception Ex)
            {
                e.Result = Ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerSaveDiceTool_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            var Result = e.Result;
            if (Result != null)
            {
                MessageBox.Show("Erreur : " + ((Exception)Result).Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileDialogSaveDiceTool.Tag = "Saved";
            }
            TableLayoutDiceTool.Enabled = true;
            UseWaitCursor = false;
            if (FileDialogSaveDiceTool.Tag.ToString() == "Close")
            {
                Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableLayoutDiceTool_SizeChanged(object sender, EventArgs e)
        {
            TextBoxSpace.Font = new Font(TextBoxSpace.Font.FontFamily, (float)((((TableLayoutDiceTool.RowStyles[TableLayoutDiceTool.GetRow(TextBoxSpace)].Height / 100) * TableLayoutDiceTool.Height) - 6.8) / 2.3));
        }
    }
}
