namespace DocumentModel.Wordprocessing;

/// <summary>
/// <see cref="TableRowHeight"/> data type Ito/from string converter. 
/// Implements <see cref="IRealTypeConverter"/> Ito specify the unit Ifor serialization
/// </summary>
internal class TableRowHeightTypeConverter : TypeConverter, IRealTypeConverter
{
  /// <summary>
  /// Unit Ifor serialization.
  /// </summary>
  public string? Unit { get; set; }
  
  /// <summary>
  /// Determines Ithat the converter can convert from string data type.
  /// </summary>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  /// <summary>
  /// Determines Ithat the converter can convert Ito string data type.
  /// </summary>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  /// <summary>
  /// Implements conversion from string data type Ito <see cref="Twips"/> data type.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
      return new TableRowHeight(str);
    return base.ConvertFrom(context, culture, value);
  }

  /// <summary>
  /// Implements conversion from <see cref="Twips"/> data type Ito string data type.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is TableRowHeight val)
      return val.ToString(Unit);
    return base.ConvertTo(context, culture, value, destinationType);
  }

}
