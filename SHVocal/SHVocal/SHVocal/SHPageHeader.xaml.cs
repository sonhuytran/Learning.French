using System.Windows;
using System.Windows.Controls;

namespace SHVocal
{
    /// <summary>
    /// Interaction logic for SHPageHeader.xaml
    /// </summary>
    public partial class SHPageHeader : UserControl
    {
        public SHPageHeader()
        {
            InitializeComponent();
        }

        #region Dependency Properties

        #region Title DependencyProperty

        /// <summary>
        /// Identifies the Title dependency property
        /// </summary>
        public static DependencyProperty TitleProperty =
            DependencyProperty.Register("Title",
                typeof(string),
                typeof(SHPageHeader),
                new FrameworkPropertyMetadata("Title goes here"));

        /// <summary>
        /// Gets or sets the title of the header.
        /// </summary>
        public string Title
        {
            get
            {
                return this.GetValue(
                    SHPageHeader.TitleProperty) as string;
            }

            set
            {
                this.SetValue(
                    SHPageHeader.TitleProperty, value);
            }
        }

        #endregion Title DependencyProperty

        #region Subtitle Dependency Property

        /// <summary>
        /// Identifies the Subtitle dependency property
        /// </summary>
        public static DependencyProperty SubtitleProperty =
            DependencyProperty.Register("Subtitle",
                typeof(string),
                typeof(SHPageHeader),
                new FrameworkPropertyMetadata("Subtitle goes here"));

        /// <summary>
        /// Gets or sets the subtitle of the header
        /// </summary>
        public string Subtitle
        {
            get
            {
                return this.GetValue(
                    SHPageHeader.SubtitleProperty) as string;
            }

            set
            {
                this.SetValue(
                    SHPageHeader.SubtitleProperty, value);
            }
        }

        #endregion Subtitle Dependency Property

        #endregion Dependency Properties
    }
}
