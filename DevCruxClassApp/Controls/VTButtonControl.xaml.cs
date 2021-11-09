using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Button.ButtonContentLayout;

namespace DevCruxClassApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VTButtonControl : ContentView
    {
        public VTButtonControl()
        {
            InitializeComponent();
            vtBtn.Text = Text;
            vtBtn.ImageSource = ImageSource;
            vtBtn.BackgroundColor = BackgroundColor;
            vtBtn.ContentLayout = new Button.ButtonContentLayout(ImagePosition.Right, 10);// "Right,10";
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
        public Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
                                                                                       typeof(string),
                                                                                       typeof(VTButtonControl),
                                                                                       default(string),
                                                                                       BindingMode.OneWay);
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource),
                                                                                       typeof(ImageSource),
                                                                                       typeof(VTButtonControl),
                                                                                       default(ImageSource),
                                                                                       BindingMode.OneWay);
        public static readonly BindableProperty BackgroundColorProperty = BindableProperty.Create(nameof(BackgroundColor),
                                                                                      typeof(Color),
                                                                                      typeof(VTButtonControl),
                                                                                      default(Color), BindingMode.OneWay);
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TextProperty.PropertyName)
            {
                vtBtn.Text = Text;
            }

            if (propertyName == ImageSourceProperty.PropertyName)
            {
                vtBtn.ImageSource = ImageSource;
            }

            if (propertyName == BackgroundColorProperty.PropertyName)
            {
                vtBtn.BackgroundColor = BackgroundColor;
            }
        }
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = e.NewTextValue;
        }
    }
}