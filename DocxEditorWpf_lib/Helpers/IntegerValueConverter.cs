namespace DocxEditor.Helpers;

public class IntegerValueConverter: IValueConverter
{
  public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    targetType = Nullable.GetUnderlyingType(targetType) ?? targetType;
    if (value == null)
    {
      return null;
    }
    if (value is int intValue && targetType == typeof(Double))
    {
      return System.Convert.ToDouble(intValue);
    }
    throw new NotImplementedException();
  }

  public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    if (value == null)
      return null;
    targetType = Nullable.GetUnderlyingType(targetType) ?? targetType;
    if (targetType == typeof(object))
      targetType = typeof(int);
    if (value is double doubleValue && targetType == typeof(int))
    {
      return System.Convert.ToInt32(doubleValue);
    }
    throw new NotImplementedException();
  }
}