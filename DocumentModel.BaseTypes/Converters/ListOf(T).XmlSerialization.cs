namespace DocumentModel;

public partial class ListOf<T> : IXmlSerializable
  where T : IConvertible
{


  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  /// <summary>
  /// Deserializes the <see cref="List{T}"/> value from XML.
  /// Accepts space-separated values (or comma/semicolon-separated for string types).
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> to read from.</param>
  /// <remarks>
  /// The method handles the following formats:
  /// <list type="bullet">
  /// <item><description>Space-separated values for numeric types (e.g., "1 2 3 4 5")</description></item>
  /// <item><description>Comma or semicolon-separated values for string types (e.g., "apple,banana,cherry" or "item1;item2;item3")</description></item>
  /// <item><description>Single values (stored as a single item in the list)</description></item>
  /// <item><description>Empty elements (creates an empty list)</description></item>
  /// </list>
  /// <para>The string is split using appropriate separators based on the element type.</para>
  /// <para>Empty entries are automatically removed.</para>
  /// <para>Each token is converted to type T using <see cref="Convert.ChangeType(object, Type)"/>.</para>
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
      string listString = reader.Value;

      if (!string.IsNullOrEmpty(listString))
      {
        Clear();
        TextValue = listString;
        
        // Parse the string using appropriate separators
        var items = listString.Split(_listSeparators, StringSplitOptions.RemoveEmptyEntries);
        foreach (var item in items)
        {
          var convertedItem = (T)Convert.ChangeType(item, typeof(T), CultureInfo.InvariantCulture);
          Add(convertedItem);
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
  /// Serializes the <see cref="List{T}"/> value to XML.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The value is written as a space-separated string with items separated by spaces.
  /// For example, a list containing 1, 2, 3 is written as "1 2 3".
  /// A list containing "apple", "banana", "cherry" is written as "apple banana cherry".
  /// If the list is empty, an empty string is written.
  /// </remarks>
  void IXmlSerializable.WriteXml(XmlWriter writer)
  {
    writer.WriteString(InnerText);
  }
}
