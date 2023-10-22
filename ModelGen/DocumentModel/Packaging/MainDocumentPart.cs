namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the body of the document.
/// </summary>
public partial class MainDocumentPart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Document? Document { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
