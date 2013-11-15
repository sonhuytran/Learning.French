using System.Windows.Controls;

namespace SHVocal
{
    /// <summary>
    /// Interaction logic for PageNewEntry.xaml
    /// </summary>
    public partial class PageNewEntry : Page
    {
        private static PageNewEntry pageNewEntry = null;

        public static PageNewEntry GetInstance()
        {
            if (null == PageNewEntry.pageNewEntry)
            {
                PageNewEntry.pageNewEntry = new PageNewEntry();
            }

            return PageNewEntry.pageNewEntry;
        }

        public PageNewEntry()
        {
            InitializeComponent();
        }
    }
}
