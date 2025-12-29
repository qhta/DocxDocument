using System.Globalization;
using System.Windows.Data;

namespace DocxEd.Converters;
public class PhaseNumberConverter: IValueConverter
{
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
   if (value is ModelGen.PPS pps)
      return (int)pps;
    return value;
  }

  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
    if (targetType==typeof(ModelGen.PPS))
    {
      int n = (int)System.Convert.ChangeType(value, typeof(int));
      return Enum.ToObject(typeof(ModelGen.PPS), n);
    }
    return value;
  }
}
