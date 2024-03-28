using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace SpriteColorsEditorAOE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SpriteColorsEditorViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = (DataContext as SpriteColorsEditorViewModel)!;
        }

        private void SpriteColorsPickerControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var defaultDir = @"C:\Program Files (x86)\Steam\steamapps\common\AoE2DE\resources\_common\palettes";
            var initDir = Directory.Exists(defaultDir) ? defaultDir : string.Empty;

            var openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = initDir,
                Filter = "JSON (*.json)|*.json",
            };

            if (openFileDialog.ShowDialog() == true)
            {
                _viewModel.DeserializeSpriteColorsJsonAsync(openFileDialog.FileName);
            }
        }



        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                CheckPathExists = true,
                Filter = "JSON (*.json)|*.json",
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                _viewModel.SerializeSpriteColorsJsonAsync(saveFileDialog.FileName);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close the spritecolors file?\nUnsaved data might get lost!",
                "Close imported spritecolors file", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                _viewModel.Close();
            }
        }

        private void Window_Drop(object sender, DragEventArgs e)
        {

        }

        private void SpriteColorsPickerControl_Drop(object sender, DragEventArgs e)
        {

        }
    }
}
