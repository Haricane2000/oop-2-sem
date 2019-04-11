using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using System.ComponentModel;
using System.Globalization;

namespace TextRedactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int countWin = 1;
        public List<String> paths;
        public MainWindow()
        {
            InitializeComponent();
            rchTextBox.SelectionChanged += new RoutedEventHandler(rchTextBox_SelectionChanged);
            styleComboBox.SelectionChanged += StyleChange;
        //    paths = new List<String>();
            paths = JsonWorker.deserializeProducts<List<String>>();
            if (paths == null)
            {
                paths = new List<String>();
            }
            SetStartItemValues();

        }
        #region Items
        private void UpdatePathList(String path)
        {
            SaveUri.saveUri(paths, path);
            listPaths.ItemsSource = paths;
        }
        private void SetResource(Uri path)
        {
            ResourceDictionary resourceDict = Application.LoadComponent(path) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
        private void StyleChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleComboBox.SelectedItem as string;
            Uri path = new Uri("Resources/Styles/" + style + ".xaml", UriKind.Relative);
            SetResource(path);
        }
        private void SetStartItemValues()
        {
            ComboBoxSettings();
            rchTextBox_Settings();
            CountWindows();
        }
        private void CountWindows()
        {
            windowsCount.Content = countWin.ToString();
            countWin++;
        }
        private void ComboBoxSettings()
        {
            ComboFontType.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            ComboFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            comboBoxLanguage.ItemsSource = new List<string>() { "en-US", "ru-RU" };
            ComboFontColor.ItemsSource = new List<string>()
            {
                "red", "green", "black", "yellow", "green", "blue"
            };
            styleComboBox.ItemsSource = new List<string> { "Default", "Dark", "Light" };
            listPaths.ItemsSource = paths;
        }
        private void comboBoxLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = "pack://application:,,,/Resources/Languages/lang." +
               comboBoxLanguage.SelectedItem+
                ".xaml";
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri(path)
            };
        }

        #endregion
        #region TextWork
        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboFontType.SelectedItem != null)
                rchTextBox.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, ComboFontType.SelectedItem);
        }
        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ComboFontSize.SelectedItem != null)
                rchTextBox.Selection.ApplyPropertyValue(Inline.FontSizeProperty, ComboFontSize.Text);
        }
        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = rchTextBox.Selection.GetPropertyValue(Inline.FontWeightProperty);

            temp = rchTextBox.Selection.GetPropertyValue(Inline.FontStyleProperty);
            temp = rchTextBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty);

            temp = rchTextBox.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            temp = rchTextBox.Selection.GetPropertyValue(Inline.FontSizeProperty);
            temp = rchTextBox.Selection.GetPropertyValue(Inline.ForegroundProperty);
        }
        #endregion
        #region FileWork
        private void rchTextBox_Settings()
        {
            rchTextBox.AddHandler(DragOverEvent, new DragEventHandler(RchPreviewDragOver), true);
            rchTextBox.AddHandler(DropEvent, new DragEventHandler(RchFileDrop), true);
        }
        public void New_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }
        public void Close_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        public void Open_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                try
                {
                    FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                    TextRange range = new TextRange(rchTextBox.Document.ContentStart, rchTextBox.Document.ContentEnd);
                    range.Load(fileStream, DataFormats.Rtf);
                    ShowPathDoc(dlg.FileName);
                    UpdatePathList(dlg.FileName);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("File could not be opened.");
                }
            }
        }
        public void Save_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(rchTextBox.Document.ContentStart, rchTextBox.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
                UpdatePathList(dlg.FileName);
            }
        }
        private void ShowPathDoc(string stringPath)
        {
            pathString.Content = stringPath;
            pathLabel.Visibility = Visibility.Visible;
        }
        private void RchFileDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(docPath[0]))
                {
                    try
                    {
                        TextRange range = new TextRange(rchTextBox.Document.ContentStart, rchTextBox.Document.ContentEnd);
                        FileStream fStream = new FileStream(docPath[0], FileMode.OpenOrCreate);
                        range.Load(fStream, DataFormats.Rtf);
                        fStream.Close();
                        ShowPathDoc(docPath[0]);
                        UpdatePathList(docPath[0]);
                    }
                    catch (ArgumentException )
                    {
                        MessageBox.Show("File could not be opened.");
                    }
                }
            }
        }
        private void RchPreviewDragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = false;
        }

        #endregion

        private void rchTextBox_PreviewMouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            label.Content= rchTextBox.CaretPosition.Parent.GetValue(FontFamilyProperty).ToString();
            label_Copy.Content = rchTextBox.CaretPosition.Parent.GetValue(FontSizeProperty).ToString();

        }
        private void rchTextBox_SelectionChanged(object sender, EventArgs e)
        {
            TextPointer caretPos = rchTextBox.CaretPosition;
            TextPointer p = rchTextBox.CaretPosition.GetLineStartPosition(0);
            int currentColumnNumber = Math.Max(p.GetOffsetToPosition(caretPos) - 1, 0);
            labelCountSymbols.Content = currentColumnNumber.ToString();
        }

        private void ComboFontColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboFontColor.SelectedItem != null)
            {
                rchTextBox.Selection.ApplyPropertyValue(Inline.ForegroundProperty,ComboFontColor.SelectedItem.ToString());
            }
        }

        private void listPaths_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = listPaths.SelectedItem.ToString();
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                TextRange range = new TextRange(rchTextBox.Document.ContentStart, rchTextBox.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
                ShowPathDoc(path);
                UpdatePathList(path);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("File could not be opened.");
            }
        }
    }
}
