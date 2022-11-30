namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentTasksPart
/// </summary>
public interface IDocumentTasksPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Office2021.DocumentTasks.ITasks? Tasks { get ; set; }
  
}
