namespace DocumentModel.Math;

/// <summary>
/// Converts <see cref="RowSpacing"/> typed value to/from string.
/// </summary>
public class RowSpacingTypeConverter : TypeConverter
{
  /// <summary>
  /// Specifies that conversion to string is valid.
  /// </summary>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  /// <summary>
  /// Specifies that conversion from string is valid.
  /// </summary>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  /// <summary>
  /// Converts to string.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is RowSpacing val)
      return val.ToString();
    return base.ConvertTo(context, culture, value, destinationType);
  }

  /// <summary>
  /// Converts from string.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
      return new RowSpacing(str);
    return base.ConvertFrom(context, culture, value);
  }

}
