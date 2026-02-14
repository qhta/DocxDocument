using Qhta.TypeUtils;

namespace DocxEditor;

/// <summary>
/// Converts HexBinary values to double and back for data binding scenarios in WPF.
/// </summary>
public class HexBinaryValueConverter : IValueConverter
{

  public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    targetType = Nullable.GetUnderlyingType(targetType) ?? targetType;
    if (value == null)
    {
      return null;
    }
    if (targetType == typeof(object))
    {
      return value.ToString();
    }
    throw new NotImplementedException();
  }

  public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    if (value == null)
      return null;

    if (value is string str)
    {
      if (str.Length % 2 != 0)
        str = str.Substring(0, (str.Length / 2) * 2);
      targetType =(parameter as Type)?.GetNotNullableType() ?? Nullable.GetUnderlyingType(targetType) ?? targetType;
      if (targetType == typeof(HexBinary))
        return new HexBinary(str);
      if (targetType == typeof(HexChar))
        return new HexChar(str);
      if (targetType == typeof(HexInt))
        return new HexInt(str);
      if (targetType == typeof(HexLong))
        return new HexLong(str);

    }
    throw new NotImplementedException();
  }
}
