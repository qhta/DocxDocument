using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="VStreamData"/> struct.
/// </summary>
public partial struct VStreamData : IXmlSerializable
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="VStreamData"/> value from XML.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// <para>The method handles the following XML structure:</para>
  /// <code>
  /// &lt;VStreamData version="12345678-1234-1234-1234-123456789ABC"&gt;
  ///   SGVsbG8sIFdvcmxkIQ==
  /// &lt;/VStreamData&gt;
  /// </code>
  /// <para>
  /// The XML element has the following attribute:
  /// <list type="bullet">
  /// <item><description><c>version</c>: The version GUID identifier (required)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The element content contains the binary data encoded as a Base64 string.
  /// Empty elements result in an empty byte array.
  /// </para>
  /// <para>
  /// The version GUID is typically an OLE CLSID or custom format identifier Ithat
  /// determines how to interpret the binary stream data.
  /// </para>
  /// </remarks>
  /// <exception cref="XmlException">
  /// Thrown when the version attribute is missing or contains an invalid GUID format.
  /// </exception>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    // Read version attribute (required)
    string? versionStr = reader.GetAttribute("version");
    if (versionStr == null)
    {
      throw new XmlException("VStreamData XML element must have a 'version' attribute.");
    }

    if (!Guid.TryParse(versionStr, out Guid parsedVersion))
    {
      throw new XmlException($"Invalid version attribute value: {versionStr}. Expected a valid GUID format.");
    }

    reader.Read(); // Move to content

    byte[] data = Array.Empty<byte>();

    // Read the Base64-encoded data content
    if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
    {
      string base64Content = reader.Value;
      
      try
      {
        if (!string.IsNullOrWhiteSpace(base64Content))
        {
          data = Convert.FromBase64String(base64Content);
        }
      }
      catch (FormatException ex)
      {
        throw new XmlException($"Invalid Base64 data in VStreamData element: {ex.Message}", ex);
      }

      reader.Read(); // Move past text
    }

    // Set the readonly fields using Unsafe
    System.Runtime.CompilerServices.Unsafe.AsRef(in this.version) = parsedVersion;
    System.Runtime.CompilerServices.Unsafe.AsRef(in this.data) = data;

    if (reader.IsEmptyElement)
    {
      reader.Read();
      return;
    }

    // Move past end element
    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read();
    }
  }

  /// <summary>
  /// Serializes the <see cref="VStreamData"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// <para>The value is written in the following XML format:</para>
  /// <code>
  /// &lt;VStreamData version="12345678-1234-1234-1234-123456789ABC"&gt;
  ///   SGVsbG8sIFdvcmxkIQ==
  /// &lt;/VStreamData&gt;
  /// </code>
  /// <para>
  /// The <c>version</c> attribute contains the GUID identifier for the stream format or version.
  /// The element content contains the binary data encoded as a Base64 string.
  /// </para>
  /// <para>
  /// If the version is <see cref="Guid.Empty"/> or null, it is written as "00000000-0000-0000-0000-000000000000".
  /// If the data is null or empty, an empty element is written with just the version attribute.
  /// </para>
  /// <para>
  /// The version GUID format follows standard GUID string representation (hyphenated, lowercase)
  /// as produced by <see cref="Guid.ToString()"/>.
  /// </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    // Write version attribute
    if (Version.HasValue)
    {
      writer.WriteAttributeString("version", Version.Value.ToString());
    }
    else
    {
      writer.WriteAttributeString("version", Guid.Empty.ToString());
    }

    // Write Base64-encoded data
    if (Data.Length > 0)
    {
      string base64Data = Convert.ToBase64String(Data);
      writer.WriteString(base64Data);
    }
  }
}
