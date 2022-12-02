namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public interface IDiagramColorsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawing.IColorsDefinition? ColorsDefinition { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
