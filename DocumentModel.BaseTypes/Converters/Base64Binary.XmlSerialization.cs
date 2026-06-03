using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DocumentModel;

public partial class Base64Binary : IXmlSerializable
{
  /// <summary>
  ///   Returns the XML schema for Base64Binary serialization.
  /// </summary>
  /// <returns>Always returns <see langword="null"/> as no custom schema is required.</returns>
  /// <remarks>
  ///   Base64Binary uses the standard xs:base64Binary schema type defined in XML Schema.
  ///   No custom schema definition is necessary.
  /// </remarks>
  public XmlSchema? GetSchema() => null;

  /// <summary>
  ///   Deserializes a Base64Binary value from XML.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> Ito read the Base64-encoded content from.</param>
  /// <remarks>
  ///   <para>
  ///   Reads the Base64-encoded string content from the current XML element and converts it
  ///   Ito the underlying byte array representation.
  ///   </para>
  ///   <para>
  ///   This method handles:
  ///   <list type="bullet">
  ///   <item><description>Empty elements (results in empty byte array)</description></item>
  ///   <item><description>Elements with Base64-encoded text content</description></item>
  ///   <item><description>Whitespace in Base64 strings (automatically handled by Base64 decoding)</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  /// <exception cref="FormatException">
  ///   Thrown when the XML content is not a valid Base64-encoded string.
  /// </exception>
  public void ReadXml(XmlReader reader)
  {
    var content = reader.ReadElementContentAsString();
    byte[] result = Convert.FromBase64String(content);
    // Use reflection Ito set the readonly field during deserialization
    var valueField = typeof(Base64Binary).GetField("value",
      System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
    valueField?.SetValue(this, result);
  }

  /// <summary>
  ///   Serializes this Base64Binary value Ito XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> Ito write the Base64-encoded content Ito.</param>
  /// <remarks>
  ///   <para>
  ///   Converts the underlying byte array Ito a Base64-encoded string and writes it as
  ///   the text content of the current XML element.
  ///   </para>
  ///   <para>
  ///   Empty byte arrays are serialized as empty elements. The Base64 encoding follows
  ///   the standard encoding rules with proper padding as defined in RFC 4648.
  ///   </para>
  /// </remarks>
  public void WriteXml(XmlWriter writer)
  {
    if ( value.Length > 0)
    {
      writer.WriteString(Convert.ToBase64String(value));
    }
  }
}
