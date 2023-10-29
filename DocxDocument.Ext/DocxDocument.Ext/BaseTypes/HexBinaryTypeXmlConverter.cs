using Qhta.Xml;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

internal class HexBinaryTypeXmlConverter : TypeConverter
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
      return new HexBinary(str);
    return base.ConvertFrom(context, culture, value);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is HexBinary hexBinary)
      return hexBinary.ToString();
    return base.ConvertTo(context, culture, value, destinationType);
  }

  public bool CanRead => true;
  public bool CanWrite => false;

  public void WriteXml(object? context, IXmlWriter writer, object? value, IXmlSerializer? serializer)
  {
    throw new NotImplementedException();
  }

  public object? ReadXml(object? context, IXmlReader reader, Type objectType, object? existingValue, IXmlSerializer? serializer)
  {
    reader.Read(); // read pass start element;
    var str = reader.Value;
    var val = new HexBinary(str);
    reader.Read(); // read pass string value;
    reader.Read(); // read pass end element;
    return val;
  }

  public bool CanConvert(Type objectType)
  {
    return objectType == typeof(HexBinary);
  }
}