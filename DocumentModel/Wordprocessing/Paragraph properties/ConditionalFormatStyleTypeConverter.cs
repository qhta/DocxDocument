namespace DocumentModel.Wordprocessing;

/// <summary>
/// Type converter for ConditionalFormatStyle type
/// </summary>
public class ConditionalFormatStyleTypeConverter: TypeConverter
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
  /// Converts the string value to ConditionalFormatStyle object.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      var result = new ConditionalFormatStyle();
      result.Val = Enum.Parse<ConditionalFormatFlags>(str);
      return result;
    }
    return base.ConvertFrom(context, culture, value);
  }

  /// <summary>
  /// Converts the ConditionalFormatStyle object to string value.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is ConditionalFormatStyle style)
    {
      return style.Val.ToString();
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }
}
