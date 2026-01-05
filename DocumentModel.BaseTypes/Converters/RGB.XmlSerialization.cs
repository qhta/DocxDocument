namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="RGB"/> structure.
/// </summary>
public partial struct RGB : IXmlSerializable
{
  #region IXmlSerializable Implementation

  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="RGB"/> value from XML.
  /// Accepts 6-digit hexadecimal string values representing RGB colors.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// The method handles the following formats:
  /// <list type="bullet">
  /// <item><description>6-digit hexadecimal string (e.g., "FF0000" for red, "00FF00" for green, "0000FF" for blue)</description></item>
  /// <item><description>Empty elements</description></item>
  /// </list>
  /// The format is RRGGBB where RR is the red component, GG is the green component, and BB is the blue component.
  /// </remarks>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    if (reader.IsEmptyElement)
    {
      reader.Read();
      return;
    }

    reader.Read(); // Move to content

    if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
    {
      string rgbString = reader.Value;

      if (!string.IsNullOrEmpty(rgbString))
      {
        RGB parsedValue = new RGB(rgbString);

        // Use Unsafe.AsRef to update the readonly field
        System.Runtime.CompilerServices.Unsafe.AsRef(in value) = parsedValue.value;
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  /// Serializes the <see cref="RGB"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written as a 6-digit hexadecimal string in the format RRGGBB.
  /// For example, red is written as "FF0000", green as "00FF00", and blue as "0000FF".
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }

  #endregion
}