using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Windows.Data;

namespace SHVocal
{
    /// <summary>
    /// Interaction logic for PageAllEntries.xaml
    /// </summary>
    public partial class PageAllEntries : Page
    {
        private static PageAllEntries pageAllEntries = null;

        public static PageAllEntries GetInstance()
        {
            if (null == PageAllEntries.pageAllEntries)
            {
                PageAllEntries.pageAllEntries = new PageAllEntries();
            }

            return PageAllEntries.pageAllEntries;
        }

        public PageAllEntries()
        {
            InitializeComponent();
        }

        private CollectionViewSource translationViewSource = null;
        private SHVocalDBEntities entities = null;

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            entities = new SHVocalDBEntities();
            translationViewSource = ((CollectionViewSource)(
                this.FindResource("translationViewSource")));
            translationViewSource.Source = from translation in entities.Translation
                                           select translation;
        }
    }
}