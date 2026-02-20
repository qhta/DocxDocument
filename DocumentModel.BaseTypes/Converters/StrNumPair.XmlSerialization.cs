namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="StrNumPair"/> structure.
/// </summary>
public partial struct StrNumPair : IXmlSerializable
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="StrNumPair"/> value from XML.
  /// Accepts values in the format "(Str,Num)" or plain string values.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// The method handles the following formats:
  /// <list type="bullet">
  /// <item><description>Format "(Str,Num)" where both components are parsed (e.g., "(abc,123)" or "(,456)" or "(xyz,)")</description></item>
  /// <item><description>Plain string values (stored as the Str component with Num set to null)</description></item>
  /// <item><description>Empty elements</description></item>
  /// </list>
  /// When parsing the "(Str,Num)" format, the numeric component is parsed as an integer if possible, otherwise set to null.
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
      string strNumString = reader.Value;

      if (!string.IsNullOrEmpty(strNumString))
      {
        StrNumPair parsedValue = new StrNumPair(strNumString);

        // Use SetValue to update this instance
        this = SetValue(parsedValue.Str, parsedValue.Num);
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  /// Serializes the <see cref="StrNumPair"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written in the format "(Str,Num)".
  /// For example, a pair with Str="abc" and Num=123 is written as "(abc,123)".
  /// If either component is null, it will be represented as empty in the format (e.g., "(,123)" or "(abc,)").
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}