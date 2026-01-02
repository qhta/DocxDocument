namespace DocumentModel.Drawings;
/// <summary>
/// Type converter fort Extent type.
/// </summary>
internal class ExtentTypeConverter : TypeConverter
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
  /// Converts the string value to Extent object.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      var ss = str.Split(';');
      return new Extent{ Cx = new EMU(ss[0]), Cy = new EMU(ss[1]) };
    }
    return base.ConvertFrom(context, culture, value);
  }
  /// <summary>
  /// Converts the Extent object to string value.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is Extent extent)
      return $"{extent.Cx};{extent.Cy}";
    return base.ConvertTo(context, culture, value, destinationType);
  }
}