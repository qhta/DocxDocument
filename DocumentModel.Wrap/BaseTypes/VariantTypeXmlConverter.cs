using System.Runtime.CompilerServices;
using System.Xml;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

internal class VariantTypeXmlConverter : VariantTypeConverter, IXmlConverter
{
  public virtual bool CanRead => true;

  public virtual bool CanWrite => true;

  public bool CanConvert(Type objectType)
  {
    return objectType.IsEqualOrSubclassOf(typeof(Variant));
  }

  public void WriteXml(object? context, IXmlWriter writer, object? value, IXmlSerializer? serializer)
  {
    if (value is VectorVariant)
    {
      new VectorTypeXmlConverter().WriteXml(context, writer, value, serializer);
    }
    else
    if (value is ArrayVariant)
    {
      new ArrayXmlTypeConverter().WriteXml(context, writer, value, serializer);
    }
    else if (value is Variant variant && context == null)
    {
      writer.WriteStartElement("Variant");
      writer.WriteAttributeString("TypeName", variant.TypeName);
      var valueStr = base.ConvertToInvariantString(value);
      if (valueStr != null)
        writer.WriteValue(valueStr);
      writer.WriteEndElement("Variant");
    }
    else
    {
      var valueStr = base.ConvertToInvariantString(value);
      if (valueStr != null)
        writer.WriteValue(valueStr);
    }
  }

  public object? ReadXml(object? context, IXmlReader reader, Type objectType, object? existingValue, IXmlSerializer? serializer)
  {
    if (reader.NodeType == XmlNodeType.EndElement)
    {
      return new Variant("");
    }
    else
    if (reader.NodeType == XmlNodeType.Element)
    {
      if (reader.LocalName == "Variant")
      {
        var typeName = reader.GetAttribute("TypeName");
        Type? aType = null;
        if (!Enum.TryParse<VariantType>(typeName, out var variantType))
        {
          if (typeName != null && serializer!=null)
          {
            if (!serializer.TryGetKnownType(typeName, out var type))
              type = Type.GetType(typeName);
            aType = type;
            if (type != null && type.IsEnum)
              variantType = VariantType.Enum;
            else
              variantType = VariantType.Object;
          }
        }
        var str = reader.ReadElementContentAsString();
        Variant variant;
        if (aType!=null && serializer?.TryGetTypeConverter(aType, out var converter)==true)
        {
          var val = converter.ConvertFrom(str);
          variant = new Variant(variantType, aType, val);
        }
        else
          variant = new Variant(variantType, aType, str);
        if (reader.NodeType == XmlNodeType.EndElement)
          reader.Read();
        return variant;
      }
      else
      if (reader.LocalName == "Vector")
        return new VectorTypeXmlConverter().ReadXml(context, reader, objectType, existingValue, serializer);
      else
      throw new NotImplementedException($"Unexpected reader node type {reader.NodeType}");
    }
    else
    if (reader.NodeType == XmlNodeType.Text)
    {
      var str = reader.ReadString();
      var variant = new Variant(str);
      if (reader.NodeType == XmlNodeType.EndElement)
        reader.Read();
      return variant;
    }
    else
      throw new NotImplementedException($"Unexpected reader node type {reader.NodeType}");
  }

  private void ThrowNotImplemented(string msg, [CallerMemberName] string? callerName = null) 
  {
    throw new NotImplementedException($"{msg} in {this.GetType()} {callerName}");
  }
}