namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains all the footnotes for the document.
/// </summary>
public partial class FootnotesPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMW.Footnotes? Footnotes { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
