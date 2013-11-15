using System.Windows.Controls;

namespace SHVocal
{
    /// <summary>
    /// Interaction logic for PageReference.xaml
    /// </summary>
    public partial class PageReference : Page
    {
        private static PageReference pageReference = null;

        public static PageReference GetInstance()
        {
            if (null == PageReference.pageReference)
            {
                PageReference.pageReference = new PageReference();
            }

            return PageReference.pageReference;
        }

        public PageReference()
        {
            InitializeComponent();
        }
    }
}
