namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains a complete package. For example, a WordprocessingML document might contain a SpreadsheetML or PresentationML document, in which case, the WordprocessingML document package would contain an embedded package part that defined that SpreadsheetML or PresentationML document.
/// </summary>
public partial class EmbeddedPackagePart
{
  public String? RelationshipType { get; set; }
  
}
