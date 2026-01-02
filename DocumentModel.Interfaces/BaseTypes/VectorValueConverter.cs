namespace DocumentModel;

internal class ValueValueConverter : TypeConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    return base.CanConvertTo(context, destinationType);
  }
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    return base.ConvertTo(context, culture, value, destinationType);
  }
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    return base.ConvertFrom(context, culture, value);
  }
}