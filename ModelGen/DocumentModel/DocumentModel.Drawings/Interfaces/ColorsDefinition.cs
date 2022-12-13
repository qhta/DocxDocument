namespace DocumentModel.Drawings;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public interface ColorsDefinition
{
  /// <summary>
  /// Unique ID
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion { get ; set; }
  
  public Collection<DocumentModel.Drawings.ColorDefinitionTitle>? ColorDefinitionTitles { get ; set; }
  
  public Collection<DocumentModel.Drawings.ColorTransformDescription>? ColorTransformDescriptions { get ; set; }
  
  public DocumentModel.Drawings.ColorTransformCategories? ColorTransformCategories { get ; set; }
  
  public Collection<DocumentModel.Drawings.ColorTransformStyleLabel>? ColorTransformStyleLabels { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
