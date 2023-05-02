namespace DocumentModel.Wordprocessing;

/// <summary>
/// Type converter for LegacyNumbering type
/// </summary>
public class LegacyNumberingTypeConverter: TypeConverter
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
  /// Converts the string value to LegacyNumbering object.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      if (str=="false")
        return new LegacyNumbering{ Use = false };
      var ss = str.Split(";");
      return new LegacyNumbering{ Use = true, Space = ss[0], Indent = ss[1] };
    }
    return base.ConvertFrom(context, culture, value);
  }

  /// <summary>
  /// Converts the LegacyNumbering object to string value.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is LegacyNumbering val)
    {
      if (!val.Use)
        return "false";
      return $"{val.Space};{val.Indent}";
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }
}
