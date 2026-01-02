namespace DocumentModel.Drawings;
/// <summary>
/// Type converter for EMU type.
/// </summary>
internal class EMUTypeConverter : TypeConverter
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
  /// Converts the string value to EMU object.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
      return new EMU(str);
    return base.ConvertFrom(context, culture, value);
  }
  /// <summary>
  /// Converts the EMU object to string value.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is EMU val)
      return val.ToString();
    return base.ConvertTo(context, culture, value, destinationType);
  }
}