using OfficeOpenXml;
using ParserDoski.Core.KupiProday;
using ParserKupiProday.Core;
using ParserKupiProday.Core.KupiProday;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ParserKupiProday
{
    //Changes for initial commit

    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        LinksParserWorker<string[]> linkParser;
        Selectable selectable;

        private Dictionary<string, string> regionsDictionary;
        private Dictionary<string, string> categorysDictionary;


        public Form1()
        {
            InitializeComponent();

            KPParser doskiParser = new KPParser();
            KPParser doskiLinkParser = new KPParser();

            parser = new ParserWorker<string[]>(doskiParser);
            linkParser = new LinksParserWorker<string[]>(doskiLinkParser);
            selectable = new Selectable();

            regionsDictionary = selectable.searchRegion;
            categorysDictionary = selectable.searchCategory;

            LinksSavePath.TextChanged += DataLoadPath_TextChanged;
            parser.OnCompleted += Parser_OnCompleted;
            //parser.StatusUpdate += Parser_StatusUpdate;
            parser.OnNewData += Parser_OnNewData;
            linkParser.OnNewLinkData += Parser_OnNewLinkData;
            linkParser.OnCompleted += Parser_OnCompleted;
            CategorySelector.SelectedIndexChanged += CategorySelector_SelectedIndexChanged;

            OblastSelector.Items.AddRange(regionsDictionary.Keys.ToArray());
            CategorySelector.Items.AddRange(categorysDictionary.Keys.ToArray());
        }
         
        private Dictionary<string, string> GetSelectedDictionary(string selectedValue)
        {
            switch (selectedValue)
            {
                case "Транспорт":
                    return selectable.transport;
                case "Недвижимость":
                    return selectable.nedvizhimost;
                case "Личные вещи":
                    return selectable.lichnoe;
                case "Электроника, техника":
                    return selectable.elektronika;
                case "Дом и сад, мебель, бытовое":
                    return selectable.domSad;
                case "Текстиль":
                    return selectable.tekstil;
                case "Животные":
                    return selectable.zhivotnie;
                case "Услуги и предложения":
                    return selectable.uslugi;
                case "Работа":
                    return selectable.rabota;
                case "Хобби, Отдых, Спорт":
                    return selectable.hobbi;
                case "Оборудование":
                    return selectable.oborudovanie;
                case "Сырье":
                    return selectable.syriyo;
                case "Строительные товары и услуги":
                    return selectable.stroytovari;
                case "Продукты питания":
                    return selectable.produkti;
                default:
                    return null; 
            }
        }

        private void Parser_OnNewLinkData(object arg1, string[] arg2)
        {
            if (LoadingVisData.Value < LoadingVisData.Maximum)
            {
                LoadingVisData.Value++;
            }

            DataTitles.Items.AddRange(arg2);
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            if (LoadingVisLinks.Value < LoadingVisLinks.Maximum)
            {
                LoadingVisLinks.Value++;
            }

            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int startValue = (int)NumericStart.Value;
            int endValue = (int)NumericEnd.Value;
            LoadingVisLinks.Minimum = 0;
            LoadingVisLinks.Maximum = endValue - startValue;
            LoadingVisLinks.Value = 0;

            string selectedValue = CategorySelector.SelectedItem.ToString();
            Dictionary<string, string> selectedDictionary = GetSelectedDictionary(selectedValue);

            string oblastSelected = OblastSelector.SelectedItem.ToString();
            string categorySelected = CategorySelector.SelectedItem.ToString();
            string subCategorySelected = SubCategorySelector.SelectedItem.ToString();

            parser.Settings = new KPSettings((int)NumericStart.Value,
                                            (int)NumericEnd.Value,
                                            categorysDictionary[categorySelected],
                                            LinksSavePath.Text,
                                            DataSavePath.Text,
                                            selectedDictionary[subCategorySelected],
                                            regionsDictionary[oblastSelected]);
            parser.Start(LinksSavePath.Text);
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            parser.Stop();
            linkParser.Stop();
        }

        private void ButtonLinkStart_Click(object sender, EventArgs e)
        {
            int rowCount = GetExcelRowCount(DataLoadPath.Text);

            int startIndex = (int)StartParseDataFrom.Value;
            int endIndex = rowCount;
            LoadingVisData.Minimum = 0;
            LoadingVisData.Maximum = endIndex - startIndex;
            LoadingVisData.Value = 0;

            string selectedValue = CategorySelector.SelectedItem.ToString();
            Dictionary<string, string> selectedDictionary = GetSelectedDictionary(selectedValue);

            string oblastSelected = OblastSelector.SelectedItem.ToString();
            string categorySelected = CategorySelector.SelectedItem.ToString();
            string subCategorySelected = SubCategorySelector.SelectedItem.ToString();

            linkParser.Settings = new KPSettings((int)NumericStart.Value,
                                            (int)NumericEnd.Value,
                                            categorysDictionary[categorySelected],
                                            LinksSavePath.Text,
                                            DataSavePath.Text,
                                            selectedDictionary[subCategorySelected],
                                            regionsDictionary[oblastSelected]);
            linkParser.LinkStart(DataLoadPath.Text, DataSavePath.Text, (int)StartParseDataFrom.Value, (int)StopParseDataOn.Value, regionsDictionary[oblastSelected]);
        }

        private int GetExcelRowCount(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Предполагается, что данные находятся на первом листе
                int rowCount = worksheet.Dimension.Rows;
                return rowCount;
            }
        }

        private void LinksSavePathSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LinksSavePath.Text = openFileDialog.FileName;
            }
        }

        private void DataSavePathSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataSavePath.Text = openFileDialog.FileName;
            }
        }

        private void DataParsePathSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataLoadPath.Text = openFileDialog.FileName;
            }
        }

        private void DataLoadPath_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DataLoadPath.Text))
            {
                // Установка значения второго текстового поля, если оно не задано
                DataLoadPath.Text = LinksSavePath.Text;
            }
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            ListTitles.Items.Clear();
            DataTitles.Items.Clear();
        }

        public void CategorySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = CategorySelector.SelectedItem.ToString();

            Dictionary<string, string> selectedDictionary = GetSelectedDictionary(selectedValue);
            SubCategorySelector.Items.Clear();
            SubCategorySelector.SelectedItem = null;

            SubCategorySelector.Items.AddRange(selectedDictionary.Keys.ToArray());
        }

    }
}
