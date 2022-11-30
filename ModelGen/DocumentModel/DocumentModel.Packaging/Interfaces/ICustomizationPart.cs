namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public interface ICustomizationPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Office.Word.ITemplateCommandGroup? TemplateCommandGroup { get ; set; }
  
}
