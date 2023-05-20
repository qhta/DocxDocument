using System.Xml;

namespace DocumentModel;

/// <summary>
/// XML converter for Color type. Converts color to/from string.
/// </summary>
internal class ColorTypeConverter : TypeConverter
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

  #region TypeConverter implementation.
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (context?.Instance as Type != typeof(DM.Color))
      return false;
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
    if (value?.GetType() == typeof(DM.Color))
      return ((DM.Color)value).ToString();
    return null;
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      if (DM.Color.TryParse(str, out var color))
        return color;
    }
    return base.ConvertFrom(context, culture, value);
  }
  #endregion

}