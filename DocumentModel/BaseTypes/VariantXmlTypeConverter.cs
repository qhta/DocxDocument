using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;

using Qhta.TypeUtils;

namespace DocumentModel.BaseTypes;

public class VariantXmlTypeConverter : VariantTypeConverter, IXmlConverter
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
      new VectorXmlTypeConverter().WriteXml(context, writer, value, serializer);
    }
    else
    if (value is ArrayVariant)
    {
      new ArrayXmlTypeConverter().WriteXml(context, writer, value, serializer);
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
        var str = reader.ReadElementContentAsString();
        var variant = new Variant(str);
        if (reader.NodeType == XmlNodeType.EndElement)
          reader.Read();
        return variant;
      }
      else
      if (reader.LocalName == "Vector")
        return new VectorXmlTypeConverter().ReadXml(context, reader, objectType, existingValue, serializer);
      else
      throw new NotImplementedException($"Unexpected reader node type {reader.NodeType}");
    }
    else
    if (reader.NodeType == XmlNodeType.Text)
    {
      var str = reader.ReadContentAsString();
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