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

namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for TypeListCountView.xaml
/// </summary>
public partial class TypeListCountView : UserControl
{
  public TypeListCountView()
  {
    InitializeComponent();
  }

  public static DependencyProperty TextProperty = DependencyProperty.Register
    ("Text", typeof(string), typeof(TypeListCountView), 
    new PropertyMetadata(null));

  //public string Text
  //{
  //  get { return (string)GetValue(TextProperty); }
  //  set { SetValue(TextProperty, value); }
  //}

  //private static void TextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
  //{
  //}

  //public void SetText(string value) { TextBlock.Text = value; }

  public string Text => TextBlock.Text;

}
