namespace DocumentModel.Drawings.Diagrams;

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
  
  public Collection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>? StyleDefinitionTitles { get ; set; }
  
  public Collection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>? StyleLabelDescriptions { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.StyleDisplayCategories? StyleDisplayCategories { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.Scene3D? Scene3D { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.StyleLabel? StyleLabel { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get ; set; }
  
}
