using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="VectorVariant"/> class.
/// </summary>
public partial class VectorVariant : IXmlSerializable
{
  #region IXmlSerializable Implementation

  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="VectorVariant"/> value from XML.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// <para>The method handles the following XML structure:</para>
  /// <code>
  /// &lt;VectorVariant baseType="Int32"&gt;
  ///   &lt;Item&gt;10&lt;/Item&gt;
  ///   &lt;Item&gt;20&lt;/Item&gt;
  ///   &lt;Item&gt;30&lt;/Item&gt;
  /// &lt;/VectorVariant&gt;
  /// </code>
  /// <para>
  /// The XML element may have an optional <c>baseType</c> attribute specifying the expected type of elements.
  /// Each vector element is represented as an <c>&lt;Item&gt;</c> child element.
  /// </para>
  /// <para>
  /// Empty elements are treated as null values. Elements are added to the vector in the order they appear.
  /// </para>
  /// </remarks>
  /// <exception cref="XmlException">
  /// Thrown when the baseType attribute contains an invalid value.
  /// </exception>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    if (reader.IsEmptyElement)
    {
      reader.Read();
      return;
    }

    // Read optional baseType attribute
    string? baseTypeStr = reader.GetAttribute("baseType");
    if (baseTypeStr != null)
    {
      if (Enum.TryParse<VariantType>(baseTypeStr, out var baseType))
      {
        BaseType = baseType;
      }
      else
      {
        throw new XmlException($"Invalid baseType value: {baseTypeStr}");
      }
    }

    reader.Read(); // Move to content

    // Read vector items
    while (reader.NodeType != XmlNodeType.EndElement)
    {
      if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "Item")
      {
        if (reader.IsEmptyElement)
        {
          // Empty element - add null
          Add(null);
          reader.Read();
        }
        else
        {
          reader.Read(); // Move to content

          if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
          {
            string itemValue = reader.Value;
            
            // Convert string to appropriate type if baseType is specified
            try
            {
              object? convertedValue = BaseType.HasValue 
                ? ConvertFromString(itemValue, BaseType.Value)
                : itemValue;
              Add(convertedValue);
            }
            catch (Exception ex)
            {
              throw new XmlException($"Failed to convert value '{itemValue}' to type {BaseType}: {ex.Message}", ex);
            }

            reader.Read(); // Move past text
          }
          else if (reader.NodeType == XmlNodeType.EndElement)
          {
            // Empty element content - add null
            Add(null);
          }

          // Move past end element
          if (reader.NodeType == XmlNodeType.EndElement)
          {
            reader.Read();
          }
        }
      }
      else
      {
        reader.Read(); // Skip whitespace and other non-element nodes
      }
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  /// Serializes the <see cref="VectorVariant"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// <para>The value is written in the following XML format:</para>
  /// <code>
  /// &lt;VectorVariant baseType="Int32"&gt;
  ///   &lt;Item&gt;10&lt;/Item&gt;
  ///   &lt;Item&gt;20&lt;/Item&gt;
  ///   &lt;Item&gt;30&lt;/Item&gt;
  /// &lt;/VectorVariant&gt;
  /// </code>
  /// <para>
  /// Each vector element is written as an <c>&lt;Item&gt;</c> element.
  /// Null values are written as empty <c>&lt;Item /&gt;</c> elements.
  /// If <see cref="BaseType"/> is specified, it is written as an attribute.
  /// </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    // Write baseType attribute if specified
    if (BaseType.HasValue)
    {
      writer.WriteAttributeString("baseType", BaseType.Value.ToString());
    }

    // Write vector items
    foreach (var item in this)
    {
      writer.WriteStartElement("Item");
      
      if (item != null)
      {
        string? stringValue = BaseType.HasValue 
          ? ConvertToString(item, BaseType.Value)
          : item.ToString();
        
        if (stringValue != null)
        {
          writer.WriteString(stringValue);
        }
      }
      
      writer.WriteEndElement();
    }
  }

  #endregion

  #region Helper Methods

  /// <summary>
  /// Converts a string value to the specified variant type.
  /// </summary>
  /// <param name="value">The string value to convert.</param>
  /// <param name="variantType">The target variant type.</param>
  /// <returns>The converted object, or null if conversion fails.</returns>
  private static object? ConvertFromString(string value, VariantType variantType)
  {
    if (string.IsNullOrEmpty(value))
      return null;

    return variantType switch
    {
      VariantType.Boolean => bool.Parse(value),
      VariantType.Byte => byte.Parse(value),
      VariantType.Int16 => short.Parse(value),
      VariantType.Int32 => int.Parse(value),
      VariantType.Int64 => long.Parse(value),
      VariantType.UInt16 => ushort.Parse(value),
      VariantType.UInt32 => uint.Parse(value),
      VariantType.UInt64 => ulong.Parse(value),
      VariantType.Single => float.Parse(value),
      VariantType.Double => double.Parse(value),
      VariantType.Decimal => decimal.Parse(value),
      VariantType.DateTime => DateTime.Parse(value),
      VariantType.String => value,
      VariantType.Char => value.Length > 0 ? value[0] : '\0',
      _ => value
    };
  }

  /// <summary>
  /// Converts an object value to its string representation based on the variant type.
  /// </summary>
  /// <param name="value">The object to convert.</param>
  /// <param name="variantType">The variant type of the value.</param>
  /// <returns>The string representation, or null if the value is null.</returns>
  private static string? ConvertToString(object value, VariantType variantType)
  {
    if (value == null)
      return null;

    return variantType switch
    {
      VariantType.DateTime when value is DateTime dt => dt.ToString("o"), // ISO 8601 format
      VariantType.Single when value is float f => f.ToString("R"), // Round-trip format
      VariantType.Double when value is double d => d.ToString("R"), // Round-trip format
      _ => value.ToString()
    };
  }

  #endregion
}