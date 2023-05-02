namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

internal class EighthPointsTypeConverter : TypeConverter
{
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
      return new EighthPoints(str);
    return base.ConvertFrom(context, culture, value);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is EighthPoints val)
      return val.ToString();
    return base.ConvertTo(context, culture, value, destinationType);
  }

}