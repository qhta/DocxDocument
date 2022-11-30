namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public interface IDiagramColorsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IColorsDefinition? ColorsDefinition { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
