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
  
  public Collection<DocumentModel.Drawings.StyleDefinitionTitle>? StyleDefinitionTitles { get ; set; }
  
  public Collection<DocumentModel.Drawings.StyleLabelDescription>? StyleLabelDescriptions { get ; set; }
  
  public DocumentModel.Drawings.StyleDisplayCategories? StyleDisplayCategories { get ; set; }
  
  public DocumentModel.Drawings.Scene3D? Scene3D { get ; set; }
  
  public DocumentModel.Drawings.StyleLabel? StyleLabel { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
