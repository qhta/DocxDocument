namespace DocumentModel.Drawings;

/// <summary>
/// Layout Definition.
/// </summary>
public interface LayoutDefinition
{
  /// <summary>
  /// uniqueId
  /// </summary>
  public String? UniqueId { get ; set; }
  
  /// <summary>
  /// minVer
  /// </summary>
  public String? MinVersion { get ; set; }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public String? DefaultStyle { get ; set; }
  
  public Collection<DocumentModel.Drawings.Title>? Titles { get ; set; }
  
  public Collection<DocumentModel.Drawings.Description>? Descriptions { get ; set; }
  
  public DocumentModel.Drawings.CategoryList? CategoryList { get ; set; }
  
  public DocumentModel.Drawings.SampleData? SampleData { get ; set; }
  
  public DocumentModel.Drawings.StyleData? StyleData { get ; set; }
  
  public DocumentModel.Drawings.ColorData? ColorData { get ; set; }
  
  public DocumentModel.Drawings.LayoutNode? LayoutNode { get ; set; }
  
  public DocumentModel.Drawings.DiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get ; set; }
  
}
