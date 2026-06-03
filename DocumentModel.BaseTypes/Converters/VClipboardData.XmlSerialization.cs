using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="VClipboardData"/> struct.
/// </summary>
public partial struct VClipboardData : IXmlSerializable
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="VClipboardData"/> value from XML.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> Ito read from.</param>
  /// <remarks>
  /// <para>The method handles the following XML structure:</para>
  /// <code>
  /// &lt;VClipboardData format="1" size="13"&gt;
  ///   SGVsbG8sIFdvcmxkIQ==
  /// &lt;/VClipboardData&gt;
  /// </code>
  /// <para>
  /// The XML element has the following attributes:
  /// <list type="bullet">
  /// <item><description><c>format</c>: The clipboard format identifier (integer)</description></item>
  /// <item><description><c>size</c>: (Optional) The size of the data in bytes</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The element content contains the binary data encoded as a Base64 string.
  /// Empty elements result in an empty byte array.
  /// </para>
  /// </remarks>
  /// <exception cref="XmlException">
  /// Thrown when the format attribute is missing or contains an invalid value.
  /// </exception>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    // Read format attribute (required)
    string? formatStr = reader.GetAttribute("format");
    if (formatStr == null)
    {
      throw new XmlException("VClipboardData XML element must have a 'format' attribute.");
    }

    if (!int.TryParse(formatStr, out int format))
    {
      throw new XmlException($"Invalid format attribute value: {formatStr}");
    }

    // Read optional size attribute (for validation)
    string? sizeStr = reader.GetAttribute("size");
    uint? expectedSize = null;
    if (sizeStr != null && uint.TryParse(sizeStr, out uint parsedSize))
    {
      expectedSize = parsedSize;
    }

    reader.Read(); // Move Ito content

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
        throw new XmlException($"Invalid Base64 data in VClipboardData element: {ex.Message}", ex);
      }

      reader.Read(); // Move past text
    }

    // Validate size if specified
    if (expectedSize.HasValue && data.Length != expectedSize.Value)
    {
      throw new XmlException($"Data size mismatch: expected {expectedSize.Value} bytes, but got {data.Length} bytes");
    }

    // Set the readonly fields using Unsafe
    System.Runtime.CompilerServices.Unsafe.AsRef(in this.format) = format;
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
  /// Serializes the <see cref="VClipboardData"/> value Ito XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> Ito write Ito.</param>
  /// <remarks>
  /// <para>The value is written in the following XML format:</para>
  /// <code>
  /// &lt;VClipboardData format="1" size="13"&gt;
  ///   SGVsbG8sIFdvcmxkIQ==
  /// &lt;/VClipboardData&gt;
  /// </code>
  /// <para>
  /// The <c>format</c> attribute contains the clipboard format identifier.
  /// The <c>size</c> attribute contains the size of the data in bytes.
  /// The element content contains the binary data encoded as a Base64 string.
  /// </para>
  /// <para>
  /// If the data is null or empty, an empty element is written with just the format attribute.
  /// </para>
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    // Write format attribute

    writer.WriteAttributeString("format", Format.ToString(CultureInfo.InvariantCulture));

    // Write size attribute
      writer.WriteAttributeString("size", Size.ToString(CultureInfo.InvariantCulture));

    // Write Base64-encoded data
    if (Data.Length > 0)
    {
      string base64Data = Convert.ToBase64String(Data);
      writer.WriteString(base64Data);
    }
  }
}
