namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPeoplePart
/// </summary>
public interface IWordprocessingPeoplePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Office2013.Word.IPeople? People { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
