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
  
  public Collection<ColorDefinitionTitle>? ColorDefinitionTitles { get ; set; }
  
  public Collection<ColorTransformDescription>? ColorTransformDescriptions { get ; set; }
  
  public ColorTransformCategories? ColorTransformCategories { get ; set; }
  
  public Collection<ColorTransformStyleLabel>? ColorTransformStyleLabels { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
