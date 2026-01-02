namespace DocumentModel.Wordprocessing;
/// <summary>
/// Type converter for NumberingFormat type
/// </summary>
public class NumberingFormatTypeConverter: TypeConverter
{
  /// <summary>
  /// Determines if a value can be converted from source type.
  /// </summary>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }
  /// <summary>
  /// Determines if a value can be converted to destination type.
  /// </summary>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }
  /// <summary>
  /// Converts the string value to NumberingFormat object.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      if (Enum.TryParse<NumberFormatKind>(str, out var kind))
        return new NumberingFormat(kind);
      return new NumberingFormat(str);
    }
    return base.ConvertFrom(context, culture, value);
  }
  /// <summary>
  /// Converts the NumberingFormat object to string value.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is NumberingFormat numberingFormat)
    {
      if (numberingFormat.Type!=null)
        return numberingFormat.Type.ToString();
      return numberingFormat.Custom;
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }
}
