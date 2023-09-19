namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains information about each of the fonts used by content in the document. When a consumer reads a WordprocessingML document, it shall use this information to determine which fonts to use to display the document when the specified fonts are not available on the consumer’s system.
/// </summary>
public partial class FontTablePart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets the FontParts of the FontTablePart
  /// </summary>
  public Collection? FontParts { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Fonts? Fonts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
