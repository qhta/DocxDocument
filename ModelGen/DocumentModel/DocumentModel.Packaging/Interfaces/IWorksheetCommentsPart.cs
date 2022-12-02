namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetCommentsPart
/// </summary>
public interface IWorksheetCommentsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.IComments? Comments { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
