using System.Xml;

using Newtonsoft.Json.Linq;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

internal class VectorValueXmlConverter : TypeConverter, IXmlConverter
{
  #region TypeConverter implementation.
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == null)
      return false;
    if (destinationType == typeof(string)) return true;
    return base.CanConvertTo(destinationType);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    return Variant.ConvertTo(context, culture, value, destinationType);
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    if (sourceType == typeof(JArray))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    var result = new VectorVariant();
    if (value is JArray jArray)
    {
      foreach (var item in jArray)
      {
        if (item is JValue jValue)
        {
          result.Add(jValue.Value);
        }
      }
      return result;
    }
    if (value is Variant variant)
      return variant;
    return base.ConvertFrom(context, culture, value);
  }
  #endregion

  #region IXmlConverter implementation.
  public bool CanConvert(Type objectType)
  {
    return objectType == typeof(VectorVariant);
  }

  public virtual bool CanRead => true;

  public virtual bool CanWrite => true;

  public void WriteXml(object? context, IXmlWriter writer, object? value, IXmlSerializer? xmlSerializer)
  {
    if (value is VectorVariant vector)
    {
      writer.WriteStartElement("Vector");
      if (vector.BaseType != null)
        writer.WriteAttributeString("baseType", vector.BaseType.ToString());
      foreach (var item in vector)
      {
        if (item == null)
        {
          writer.WriteStartElement("null");
          writer.WriteEndElement("null");
        }
        else if (xmlSerializer != null && !(item is string))
        {
          xmlSerializer.WriteObject(this, item);
        }
        else
        {
          writer.WriteStartElement(item.GetType().Name);
          var str = Convert.ToString(item, CultureInfo.InvariantCulture);
          writer.WriteString(str);
          writer.WriteEndElement(item.GetType().Name);
        }
      }
      writer.WriteEndElement("Vector");
    }
  }

  public object? ReadXml(object? context, IXmlReader reader, Type objectType, object? existingValue, IXmlSerializer? xmlSerializer)
  {
    if (reader.LocalName == "Vector")
    {
      var result = new VectorVariant();
      var ok = reader.MoveToFirstAttribute();
      while (ok && reader.NodeType == XmlNodeType.Attribute)
      {
        if (reader.LocalName == "baseType")
        {
          var baseTypeStr = reader.Value;
          if (Enum.TryParse<VariantType>(baseTypeStr, out var baseType))
            result.BaseType = baseType;
          ok = reader.MoveToNextAttribute();
        }
      }
      reader.Read();
      while (reader.NodeType == XmlNodeType.Element)
      {
        if (reader.LocalName == "null")
        {
          result.Add(null);
          reader.Read();
        }
        else if (xmlSerializer != null && reader.LocalName != "String")
        {
          var item = xmlSerializer.ReadObject(context);
          if (item != null)
            result.Add(item);
        }
        else
        {
          var typeName = reader.LocalName;
          var type = Type.GetType(typeName);
          if (type == null)
          {
            if (!typeName.Contains('.'))
              type = Type.GetType("System." + typeName);
            if (type == null)
              throw new InvalidOperationException($"Type \"{typeName}\" not found");
          }
          if (!reader.IsEmptyElement)
          {
            reader.Read();
            var str = reader.ReadContentAs(type);
            result.Add(str);
            reader.Read();
          }
          else
          {
            var constructor = type.GetConstructor(new Type[0]);
            if (constructor!=null)
            {
              var item = constructor.Invoke(new object[0]);
              result.Add(item);
            }
            else
              result.Add(null);
            reader.Read();
          }
        }
      }
      if (reader.NodeType == XmlNodeType.EndElement)
        reader.Read();
      return result;
    }
    throw new InvalidOperationException($"\"Vector\" element name expected, but {reader.LocalName} found");
  }

  #endregion
}