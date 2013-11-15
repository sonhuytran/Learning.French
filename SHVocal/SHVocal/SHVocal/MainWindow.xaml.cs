using System.Windows;
using System.Windows.Controls;

namespace SHVocal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string menuItemAllEntries = "All Entries";
        private static string menuItemNewEntry = "New Entry";
        private static string menuItemPreferences = "Preferences";

        public static string[] menuItems = new string[]
        {
            menuItemAllEntries,
            menuItemNewEntry,
            menuItemPreferences
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.lbxMenu.SelectedItem.Equals(MainWindow.menuItemAllEntries))
            {
                this.frameContent.Navigate(PageAllEntries.GetInstance());
            }
            else if (this.lbxMenu.SelectedItem.Equals(MainWindow.menuItemNewEntry))
            {
                this.frameContent.Navigate(PageNewEntry.GetInstance());
            }
            else if (this.lbxMenu.SelectedItem.Equals(MainWindow.menuItemPreferences))
            {
                this.frameContent.Navigate(PageReference.GetInstance());
            }
        }
    }
}