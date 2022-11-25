namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PowerPointAuthorsPart
/// </summary>
public interface IPowerPointAuthorsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? AuthorList { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
