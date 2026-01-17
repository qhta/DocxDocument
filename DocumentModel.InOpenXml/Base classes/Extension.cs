namespace DocumentModel;

/// <summary>
///   Represents an extension element for adding additional information to other elements.
/// </summary>
public class Extension : CollectionItem
{
  /// <summary>
  ///   Uri string that identifies the extension resource or schema.
  /// </summary>
  [XmlAttribute]
  public string? Uri { get; set; }

  protected override object? GetUpdatableOpenXmlElement()
  {
    throw new NotImplementedException();
  }
}