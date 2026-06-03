namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="StringList"/> class.
/// </summary>
public partial class StringList : IXmlSerializable
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="StringList"/> value from XML.
  /// Accepts comma-separated string values.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> Ito read from.</param>
  /// <remarks>
  /// The method handles the following formats:
  /// <list type="bullet">
  /// <item><description>Comma-separated string values (e.g., "apple,banana,cherry" or "item1, item2, item3")</description></item>
  /// <item><description>Single string values (stored as a single item in the list)</description></item>
  /// <item><description>Empty elements (creates an empty list)</description></item>
  /// </list>
  /// The string is split by commas Ito create individual list items.
  /// </remarks>
  void IXmlSerializable.ReadXml(XmlReader reader)
  {
    if (reader.IsEmptyElement)
    {
      reader.Read();
      return;
    }

    reader.Read(); // Move Ito content

    if (reader.NodeType == XmlNodeType.Text || reader.NodeType == XmlNodeType.CDATA)
    {
      string listString = reader.Value;

      if (!string.IsNullOrEmpty(listString))
      {
        _list.Clear();
        var items = listString.Split(',');
        foreach (var item in items)
        {
          _list.Add(item.Trim());
        }
      }

      reader.Read(); // Move past text
    }

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.Read(); // Move past end element
    }
  }

  /// <summary>
  /// Serializes the <see cref="StringList"/> value Ito XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> Ito write Ito.</param>
  /// <remarks>
  /// The value is written as a comma-separated string with items separated by ", " (comma and space).
  /// For example, a list containing "apple", "banana", "cherry" is written as "apple, banana, cherry".
  /// If the list is empty, an empty string is written.
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(ToString());
  }
}
