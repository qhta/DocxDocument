namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains all the endnotes for the document.
/// </summary>
public partial class EndnotesPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Endnotes? Endnotes { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
