namespace DocumentModel.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
public partial class CustomDocumentProperty: DocumentProperty
{
  /// <summary>
  /// Format ID
  /// </summary>
  [XmlAttribute]
  public String? FormatId { get; set; }

  /// <summary>
  /// Property ID
  /// </summary>
  //[XmlAttribute]
  public Int32? PropertyId { get; set; }


  /// <summary>
  /// Bookmark Link Target
  /// </summary>
  [XmlAttribute]
  public String? LinkTarget { get; set; }

}
