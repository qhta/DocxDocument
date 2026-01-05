using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Qhta.TypeUtils;

namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="Variant"/> class.
/// </summary>
public partial class Variant : IXmlSerializable
{
  #region IXmlSerializable Implementation

  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="Variant"/> value from XML.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// <para>The method handles the following XML structure:</para>
  /// <code>
  /// &lt;Variant type="Int32"&gt;42&lt;/Variant&gt;
  /// &lt;Variant type="String"&gt;Hello&lt;/Variant&gt;
  /// &lt;Variant type="Date"&gt;2024-01-15&lt;/Variant&gt;
  /// &lt;Variant type="Blob"&gt;SGVsbG8sIFdvcmxkIQ==&lt;/Variant&gt;
  /// &lt;Variant type="Enum" valueType="System.DayOfWeek"&gt;Monday&lt;/Variant&gt;
  /// </code>
  /// <para>
  /// The XML element has the following attributes:
  /// <list type="bullet">
  /// <item><description><c>type</c>: The VariantType name (required)</description></item>
  /// <item><description><c>valueType</c>: The full .NET type name for Enum and Object types (optional)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The element content contains the value in an appropriate string format:
  /// <list type="bullet">
  /// <item><description>Numeric types: Standard numeric string representation</description></item>
  /// <item><description>Date: "yyyy-MM-dd" format</description></item>
  /// <item><description>DateTime: ISO 8601 format</description></item>
  /// <item><description>Binary types: Base64-encoded string</description></item>
  /// <item><description>Boolean: "true" or "false"</description></item>
  /// <item><description>Null: Empty element</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  /// <exception cref="XmlException">
  /// Thrown when the type attribute is missing or contains an invalid VariantType value.
  /// </exception>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    if (reader.IsEmptyElement)
    {
      // Read type attribute for empty elements
      string? typeStr = reader.GetAttribute("type");
      if (typeStr != null && Enum.TryParse<VariantType>(typeStr, out var emptyType))
      {
        System.Runtime.CompilerServices.Unsafe.AsRef(in _variantType) = emptyType;
        if (emptyType == VariantType.Null)
          System.Runtime.CompilerServices.Unsafe.AsRef(in _value) = DBNull.Value;
      }
      reader.Read();
      return;
    }

    // Read type attribute (required)
    string? typeAttr = reader.GetAttribute("type");
    if (typeAttr == null)
    {
      throw new XmlException("Variant XML element must have a 'type' attribute.");
    }

    if (!Enum.TryParse<VariantType>(typeAttr, out VariantType parsedType))
    {
      throw new XmlException($"Invalid type attribute value: {typeAttr}. Expected a valid VariantType.");
    }

    // Read valueType attribute (optional, used for Enum and Object types)
    string? valueTypeAttr = reader.GetAttribute("valueType");
    Type? valueType = null;
    if (valueTypeAttr != null)
    {
      valueType = Type.GetType(valueTypeAttr);
      if (valueType == null)
      {
        throw new XmlException($"Could not resolve type: {valueTypeAttr}");
      }
    }

    reader.Read(); // Move to content

    object? value = null;

    // Read the value content
    if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
    {
      string content = reader.Value;

      // Convert string content to appropriate type
      try
      {
        value = ParseValueFromString(parsedType, content, valueType);
      }
      catch (Exception ex)
      {
        throw new XmlException($"Failed to parse Variant value for type {parsedType}: {ex.Message}", ex);
      }

      reader.Read(); // Move past text
    }
    else if (parsedType == VariantType.Null)
    {
      value = DBNull.Value;
    }
    else if (parsedType == VariantType.Empty)
    {
      value = null;
    }

    // Set the readonly fields using Unsafe
    System.Runtime.CompilerServices.Unsafe.AsRef(in _variantType) = parsedType;
    if (valueType != null)
      System.Runtime.CompilerServices.Unsafe.AsRef(in _valueType) = valueType;
    System.Runtime.CompilerServices.Unsafe.AsRef(in _value) = value;

    // Move past end element
    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read();
    }
  }

  /// <summary>
  /// Serializes the <see cref="Variant"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// <para>The value is written in the following XML format:</para>
  /// <code>
  /// &lt;Variant type="Int32"&gt;42&lt;/Variant&gt;
  /// &lt;Variant type="String"&gt;Hello&lt;/Variant&gt;
  /// &lt;Variant type="Date"&gt;2024-01-15&lt;/Variant&gt;
  /// &lt;Variant type="Blob"&gt;SGVsbG8sIFdvcmxkIQ==&lt;/Variant&gt;
  /// &lt;Variant type="Enum" valueType="System.DayOfWeek"&gt;Monday&lt;/Variant&gt;
  /// </code>
  /// <para>
  /// The <c>type</c> attribute contains the VariantType name.
  /// The <c>valueType</c> attribute is included for Enum and Object types.
  /// The element content contains the value in an appropriate string format.
  /// </para>
  /// <para>
  /// Special handling:
  /// <list type="bullet">
  /// <item><description>Date values are formatted as "yyyy-MM-dd"</description></item>
  /// <item><description>DateTime values use ISO 8601 format via XmlConvert</description></item>
  /// <item><description>Binary data is Base64-encoded</description></item>
  /// <item><description>Null and Empty types produce empty elements</description></item>
  /// <item><description>Floating-point values use XmlConvert for proper formatting</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    // Write type attribute
    writer.WriteAttributeString("type", VariantType.ToString());

    // Write valueType attribute for Enum and Object types
    if ((VariantType == VariantType.Enum || VariantType == VariantType.Object) && ValueType != null)
    {
      writer.WriteAttributeString("valueType", ValueType.AssemblyQualifiedName ?? ValueType.FullName);
    }

    // Write value content
    if (VariantType == VariantType.Null || VariantType == VariantType.Empty)
    {
      // Empty element for Null and Empty types
      return;
    }

    if (_value != null)
    {
      string? stringValue = ConvertValueToString(VariantType, _value);
      if (stringValue != null)
      {
        writer.WriteString(stringValue);
      }
    }
  }

  #endregion

  #region Helper Methods

  /// <summary>
  /// Parses a string value into the appropriate type based on the VariantType.
  /// </summary>
  private static object? ParseValueFromString(VariantType variantType, string content, Type? valueType)
  {
    switch (variantType)
    {
      case VariantType.Boolean:
        return XmlConvert.ToBoolean(content);

      case VariantType.SByte:
        return XmlConvert.ToSByte(content);

      case VariantType.Byte:
        return XmlConvert.ToByte(content);

      case VariantType.Int16:
        return XmlConvert.ToInt16(content);

      case VariantType.UInt16:
        return XmlConvert.ToUInt16(content);

      case VariantType.Int32:
        return XmlConvert.ToInt32(content);

      case VariantType.UInt32:
        return XmlConvert.ToUInt32(content);

      case VariantType.Int64:
        return XmlConvert.ToInt64(content);

      case VariantType.UInt64:
        return XmlConvert.ToUInt64(content);

      case VariantType.Integer:
      case VariantType.UnsignedInteger:
      case VariantType.Decimal:
      case VariantType.Currency:
        return XmlConvert.ToDecimal(content);

      case VariantType.Single:
        return XmlConvert.ToSingle(content);

      case VariantType.Double:
        return XmlConvert.ToDouble(content);

      case VariantType.Char:
        return XmlConvert.ToChar(content);

      case VariantType.String:
      case VariantType.Lpstr:
      case VariantType.Lpwstr:
      case VariantType.Bstr:
        return content;

      case VariantType.Date:
        return DateOnly.Parse(content);

      case VariantType.DateTime:
        return XmlConvert.ToDateTime(content, XmlDateTimeSerializationMode.RoundtripKind);

      case VariantType.Guid:
        return Guid.Parse(content);

      case VariantType.HexInt:
        return new HexInt(content);

      case VariantType.Enum:
        if (valueType == null)
          throw new XmlException("Enum type requires valueType attribute");
        return Enum.Parse(valueType, content);

      case VariantType.Blob:
      case VariantType.OBlob:
      case VariantType.Storage:
      case VariantType.OStorage:
      case VariantType.Stream:
      case VariantType.OStream:
        return Convert.FromBase64String(content);

      case VariantType.ClipboardData:
        // ClipboardData needs special handling - for now return as byte array
        return Convert.FromBase64String(content);

      case VariantType.VStream:
        // VStreamData needs special handling - for now return as byte array
        return Convert.FromBase64String(content);

      case VariantType.Variant:
        // Nested variant - could be implemented but rarely used
        return content;

      case VariantType.Null:
        return DBNull.Value;

      case VariantType.Empty:
        return null;

      default:
        return content;
    }
  }

  /// <summary>
  /// Converts a value to its string representation for XML serialization.
  /// </summary>
  private static string? ConvertValueToString(VariantType variantType, object value)
  {
    switch (variantType)
    {
      case VariantType.Boolean:
        return XmlConvert.ToString((bool)value);

      case VariantType.SByte:
        return XmlConvert.ToString((sbyte)value);

      case VariantType.Byte:
        return XmlConvert.ToString((byte)value);

      case VariantType.Int16:
        return XmlConvert.ToString((short)value);

      case VariantType.UInt16:
        return XmlConvert.ToString((ushort)value);

      case VariantType.Int32:
        return XmlConvert.ToString((int)value);

      case VariantType.UInt32:
        return XmlConvert.ToString((uint)value);

      case VariantType.Int64:
        return XmlConvert.ToString((long)value);

      case VariantType.UInt64:
        return XmlConvert.ToString((ulong)value);

      case VariantType.Integer:
      case VariantType.UnsignedInteger:
      case VariantType.Decimal:
      case VariantType.Currency:
        return XmlConvert.ToString((decimal)value);

      case VariantType.Single:
        return XmlConvert.ToString((float)value);

      case VariantType.Double:
        return XmlConvert.ToString((double)value);

      case VariantType.Char:
        return XmlConvert.ToString((char)value);

      case VariantType.String:
      case VariantType.Lpstr:
      case VariantType.Lpwstr:
      case VariantType.Bstr:
        return value.ToString();

      case VariantType.Date:
        if (value is DateOnly dateOnly)
          return dateOnly.ToString("yyyy-MM-dd");
        if (value is DateTime dt)
          return DateOnly.FromDateTime(dt).ToString("yyyy-MM-dd");
        return value.ToString();

      case VariantType.DateTime:
        if (value is DateTime dateTime)
          return XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.RoundtripKind);
        return value.ToString();

      case VariantType.Guid:
        if (value is Guid guid)
          return guid.ToString();
        return value.ToString();

      case VariantType.HexInt:
        return value.ToString();

      case VariantType.Enum:
        return value.ToString();

      case VariantType.Blob:
      case VariantType.OBlob:
      case VariantType.Storage:
      case VariantType.OStorage:
      case VariantType.Stream:
      case VariantType.OStream:
        if (value is byte[] bytes)
          return Convert.ToBase64String(bytes);
        return null;

      case VariantType.ClipboardData:
        if (value is VClipboardData clipData)
          return Convert.ToBase64String(clipData.Data);
        if (value is byte[] clipBytes)
          return Convert.ToBase64String(clipBytes);
        return null;

      case VariantType.VStream:
        if (value is VStreamData streamData)
          return Convert.ToBase64String(streamData.Data);
        if (value is byte[] streamBytes)
          return Convert.ToBase64String(streamBytes);
        return null;

      case VariantType.Variant:
        if (value is Variant variant)
          return variant.ToString(CultureInfo.InvariantCulture);
        return value.ToString();

      case VariantType.Object:
        // For objects, use TypeConverter if available
        if (value.GetType().TryGetConverter(out var converter) && converter != null)
        {
          if (converter.CanConvertTo(typeof(string)))
            return converter.ConvertToInvariantString(value);
        }
        return value.ToString();

      default:
        return value.ToString();
    }
  }

  #endregion
}