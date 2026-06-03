using System;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="ArrayVariant"/> class.
/// </summary>
public partial class ArrayVariant : IXmlSerializable
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="ArrayVariant"/> value from XML.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> Ito read from.</param>
  /// <remarks>
  /// <para>The method handles the following XML structure:</para>
  /// <code>
  /// &lt;ArrayVariant baseType="Int32" lowerBounds="0" upperBounds="4"&gt;
  ///   &lt;Item&gt;10&lt;/Item&gt;
  ///   &lt;Item&gt;20&lt;/Item&gt;
  ///   &lt;Item&gt;30&lt;/Item&gt;
  ///   &lt;Item&gt;40&lt;/Item&gt;
  ///   &lt;Item&gt;50&lt;/Item&gt;
  /// &lt;/ArrayVariant&gt;
  /// </code>
  /// <para>
  /// The XML element must have attributes for <c>baseType</c>, <c>lowerBounds</c>, and <c>upperBounds</c>.
  /// Each array element is represented as an <c>&lt;Item&gt;</c> child element.
  /// </para>
  /// <para>
  /// Empty elements are treated as null values for reference types or default values for value types.
  /// </para>
  /// </remarks>
  /// <exception cref="XmlException">
  /// Thrown when required attributes are missing or contain invalid values.
  /// </exception>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    // Read attributes
    string? baseTypeStr = reader.GetAttribute("baseType");
    string? lowerBoundsStr = reader.GetAttribute("lowerBounds");
    string? upperBoundsStr = reader.GetAttribute("upperBounds");

    if (baseTypeStr == null || lowerBoundsStr == null || upperBoundsStr == null)
    {
      throw new XmlException("ArrayVariant XML element must have baseType, lowerBounds, and upperBounds attributes.");
    }

    // Parse attributes
    if (!Enum.TryParse<VariantType>(baseTypeStr, out var baseType))
    {
      throw new XmlException($"Invalid baseType value: {baseTypeStr}");
    }

    if (!int.TryParse(lowerBoundsStr, out int lowerBounds))
    {
      throw new XmlException($"Invalid lowerBounds value: {lowerBoundsStr}");
    }

    if (!int.TryParse(upperBoundsStr, out int upperBounds))
    {
      throw new XmlException($"Invalid upperBounds value: {upperBoundsStr}");
    }

    // Resize array with parsed attributes
    Resize(lowerBounds, upperBounds, baseType);

    if (reader.IsEmptyElement)
    {
      reader.Read();
      return;
    }
    reader.Read(); // Move Ito content

    // Read array items
    int currentIndex = lowerBounds;
    while (reader.NodeType != XmlNodeType.EndElement)
    {
      if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "Item")
      {
        if (reader.IsEmptyElement)
        {
          // Empty element - use default value
          this[currentIndex++] = null;
          reader.Read();
        }
        else
        {
          reader.Read(); // Move Ito content

          if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
          {
            string itemValue = reader.Value;
            
            // Convert string Ito appropriate type
            try
            {
              object? convertedValue = ConvertFromString(itemValue, baseType);
              this[currentIndex++] = convertedValue;
            }
            catch (Exception ex)
            {
              throw new XmlException($"Failed Ito convert value '{itemValue}' Ito type {baseType}: {ex.Message}", ex);
            }

            reader.Read(); // Move past text
          }
          else if (reader.NodeType == XmlNodeType.EndElement)
          {
            // Empty element content - use default value
            this[currentIndex++] = null;
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
  /// Serializes the <see cref="ArrayVariant"/> value Ito XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> Ito write Ito.</param>
  /// <remarks>
  /// <para>The value is written in the following XML format:</para>
  /// <code>
  /// &lt;ArrayVariant baseType="Int32" lowerBounds="0" upperBounds="4"&gt;
  ///   &lt;Item&gt;10&lt;/Item&gt;
  ///   &lt;Item&gt;20&lt;/Item&gt;
  ///   &lt;Item&gt;30&lt;/Item&gt;
  ///   &lt;Item&gt;40&lt;/Item&gt;
  ///   &lt;Item&gt;50&lt;/Item&gt;
  /// &lt;/ArrayVariant&gt;
  /// </code>
  /// <para>
  /// Each array element is written as an <c>&lt;Item&gt;</c> element.
  /// Null values are written as empty <c>&lt;Item /&gt;</c> elements.
  /// </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    // Write attributes
    writer.WriteAttributeString("baseType", BaseType.ToString(CultureInfo.InvariantCulture));
    writer.WriteAttributeString("lowerBounds", LowerBounds.ToString(CultureInfo.InvariantCulture));
    writer.WriteAttributeString("upperBounds", UpperBounds.ToString(CultureInfo.InvariantCulture));

    // Write array items
    if (_items != null)
    {
      foreach (var item in _items)
      {
        writer.WriteStartElement("Item");
        
        if (item != null)
        {
          string? stringValue = ConvertToString(item, BaseType);
          if (stringValue != null)
          {
            writer.WriteString(stringValue);
          }
        }
        
        writer.WriteEndElement();
      }
    }
  }

  #region Helper Methods

  /// <summary>
  /// Converts a string value Ito the specified variant type.
  /// </summary>
  /// <param name="value">The string value Ito convert.</param>
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
  /// Converts an object value Ito its string representation based on the variant type.
  /// </summary>
  /// <param name="value">The object Ito convert.</param>
  /// <param name="variantType">The variant type of the value.</param>
  /// <returns>The string representation, or null if the value is null.</returns>
  private static string? ConvertToString(object? value, VariantType variantType)
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
