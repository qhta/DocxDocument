using System.Xml.Schema;
using System.Xml.Serialization;

namespace DocumentModel;

/// <summary>
///   XML converter that serializes HexBinary values as hexadecimal strings in XML.
/// </summary>
/// <remarks>
///   <para>
///   This converter ensures that HexBinary values are written as text content in XML elements
///   and attributes (e.g., &lt;id&gt;A1B2C3&lt;/id&gt;) rather than complex structures or base64
///   encoded binary data. This format is required by the Office Open XML specification.
///   </para>
///   <para>
///   During deserialization, the converter reads string content from XML and constructs HexBinary
///   instances, validating that all characters are valid hexadecimal digits.
///   </para>
/// </remarks>
public class HexBinaryXmlConverter : IXmlSerializable
{
  private HexBinary? _value;

  /// <summary>
  ///   Gets or sets the HexBinary value being serialized.
  /// </summary>
  public HexBinary? Value
  {
    get => _value;
    set => _value = value;
  }

  /// <summary>
  ///   Returns null to indicate that this type has no schema.
  /// </summary>
  public XmlSchema? GetSchema() => null;

  /// <summary>
  ///   Reads a HexBinary value from XML as string content.
  /// </summary>
  public void ReadXml(XmlReader reader)
  {
    if (reader.IsEmptyElement)
    {
      reader.Read();
      _value = null;
      return;
    }

    reader.Read();
    if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
    {
      string hexString = reader.ReadContentAsString();
      if (!string.IsNullOrEmpty(hexString))
      {
        var hexBinary = CreateHexBinaryInstance();
        hexBinary.FromString(hexString);
        _value = hexBinary;
      }
    }

    reader.ReadEndElement();
  }

  /// <summary>
  ///   Writes a HexBinary value to XML as string content.
  /// </summary>
  public void WriteXml(XmlWriter writer)
  {
    if (_value != null)
    {
      string hexString = _value.ToString();
      writer.WriteString(hexString);
    }
  }

  /// <summary>
  ///   Creates an instance of the concrete HexBinary implementation.
  /// </summary>
  private static HexBinary CreateHexBinaryInstance()
  {
    return new HexBinary(Array.Empty<byte>());
  }
}