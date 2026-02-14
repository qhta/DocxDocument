using Qhta.TypeUtils;
using System.Windows.Data;

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
    return value.ToString();
  }

  public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    if (value == null)
      return null;

    if (value is string str)
    {
      var normalized = str.Replace(" ", string.Empty);
      if (string.IsNullOrEmpty(normalized))
      {
        return Binding.DoNothing;
      }

      targetType =(parameter as Type)?.GetNotNullableType() ?? Nullable.GetUnderlyingType(targetType) ?? targetType;
      if (targetType == typeof(HexBinary))
      {
        if (normalized.Length % 2 != 0)
        {
          return Binding.DoNothing;
        }
        return new HexBinary(normalized);
      }
      if (targetType == typeof(HexChar))
      {
        if (normalized.Length > 4)
        {
          return Binding.DoNothing;
        }
        return new HexChar(normalized);
      }
      if (targetType == typeof(HexInt))
      {
        if (normalized.Length > 8)
        {
          return Binding.DoNothing;
        }
        return new HexInt(normalized);
      }
      if (targetType == typeof(HexLong))
      {
        if (normalized.Length > 16)
        {
          return Binding.DoNothing;
        }
        return new HexLong(normalized);
      }

    }
    throw new NotImplementedException();
  }
}
