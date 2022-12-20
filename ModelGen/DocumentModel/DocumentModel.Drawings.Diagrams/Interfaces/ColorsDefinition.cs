namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public partial interface ColorsDefinition
{
  /// <summary>
  /// Unique ID
  /// </summary>
  public String? UniqueId { get; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion { get; set; }
  
  public Collection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>? ColorDefinitionTitles { get; set; }
  
  public Collection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>? ColorTransformDescriptions { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ColorTransformCategories? ColorTransformCategories { get; set; }
  
  public Collection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>? ColorTransformStyleLabels { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
