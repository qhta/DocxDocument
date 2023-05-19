namespace DocumentModel;

/// <summary>
/// XML converter for Color type. Converts color to/from string.
/// </summary>
internal class ColorTypeConverter : TypeConverter
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is DMW.ThemeColor themeColor)
      return themeColor.ToString();
    if (value is DM.Color color)
      return color.ToString();
    return base.ConvertTo(context, culture, value, destinationType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      if (DM.Color.TryParse(str, out var color))
        return color;
      if (DMW.ThemeColor.TryParse(str, out var themeColor))
        return themeColor;
    }
    return base.ConvertFrom(context, culture, value);
  }


}