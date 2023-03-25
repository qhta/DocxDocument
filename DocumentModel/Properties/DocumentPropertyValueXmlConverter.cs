using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentModel;
using DocumentModel.Drawings;

using Qhta.TestHelper;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

internal class DocumentPropertyValueXmlConverter : ValueTypeConverter, IXmlConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    return destinationType == typeof(string);
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    return sourceType == typeof(string);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (context?.Instance is DocumentProperty documentProperty)
    {
      ExpectedType = documentProperty.Type;
    }
    return base.ConvertFrom(context, Culture, value);
  }


  public bool CanRead => true;
  public bool CanWrite => true;

  public void WriteXml(object? context, IXmlWriter writer, object? value, IXmlSerializer? serializer)
  {
    if (value != null)
    {
      var valueType = value.GetType();
      if (!valueType.IsSimple())
        TestTools.Stop();
      var valueTypeConverter = new ValueTypeConverter(valueType);
      if (valueTypeConverter.CanConvertTo(typeof(string)))
      {
        var str = valueTypeConverter.ConvertToInvariantString(context != null ? new TypeDescriptorContext(context) : null, value);
        if (str != null)
        {
          writer.WriteString(str);
          return;
        }
      }
      serializer?.WriteObject(context, value);
    }
  }

  public object? ReadXml(object? context, IXmlReader reader, Type objectType, object? existingValue, IXmlSerializer? serializer)
  {
    if (context is DocumentProperty documentProperty)
    {
      var expectedType = documentProperty.Type;
      if (expectedType != null)
      {
        if (expectedType.Name == "Variant")
        {
          return new VariantTypeXmlConverter().ReadXml(context, reader, objectType, existingValue, serializer);
        }
        else
        { 
        var valueTypeConverter = new ValueTypeConverter(expectedType);
        if (valueTypeConverter.CanConvertFrom(typeof(string)))
        {
          string? str = null;
          if (reader.NodeType == System.Xml.XmlNodeType.Text)
            str = reader.ReadString();
          else if (reader.NodeType == System.Xml.XmlNodeType.EndElement)
            str = "";
          if (str != null)
          {
            var val = valueTypeConverter.ConvertFromInvariantString(context != null ? new TypeDescriptorContext(context) : null, str);
            return val;
          }
        }
        var value = serializer?.ReadObject(context);
        return value;
      }
    }
  }
    return null;
  }

public bool CanConvert(Type objectType)
{
  return true;
}
}
