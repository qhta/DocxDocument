namespace DocumentModel.Drawings;

/// <summary>
/// Style Definition.
/// </summary>
public interface StyleDefinition
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public String? MinVersion { get ; set; }
  
  public Collection<StyleDefinitionTitle>? StyleDefinitionTitles { get ; set; }
  
  public Collection<StyleLabelDescription>? StyleLabelDescriptions { get ; set; }
  
  public StyleDisplayCategories? StyleDisplayCategories { get ; set; }
  
  public Scene3D? Scene3D { get ; set; }
  
  public StyleLabel? StyleLabel { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
