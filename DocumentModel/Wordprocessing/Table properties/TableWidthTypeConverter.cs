namespace DocumentModel.Wordprocessing;

/// <summary>
/// <see cref="TableWidth"/> data type to/from string converter. 
/// Implements <see cref="IRealTypeConverter"/> to specify the unit for serialization
/// </summary>
internal class TableWidthTypeConverter : TypeConverter, IRealTypeConverter
{
  /// <summary>
  /// Unit for serialization.
  /// </summary>
  public string? Unit { get; set; }
  
  /// <summary>
  /// Determines that the converter can convert from string data type.
  /// </summary>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  /// <summary>
  /// Determines that the converter can convert to string data type.
  /// </summary>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  /// <summary>
  /// Implements conversion from string data type to <see cref="Twips"/> data type.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
      return new TableWidth(str);
    return base.ConvertFrom(context, culture, value);
  }

  /// <summary>
  /// Implements conversion from <see cref="Twips"/> data type to string data type.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is TableWidth val)
      return val.ToString(Unit);
    return base.ConvertTo(context, culture, value, destinationType);
  }

}