namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
public partial interface LayoutDefinition
{
  /// <summary>
  /// uniqueId
  /// </summary>
  public String? UniqueId { get; set; }
  
  /// <summary>
  /// minVer
  /// </summary>
  public String? MinVersion { get; set; }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public String? DefaultStyle { get; set; }
  
  public Collection<DocumentModel.Drawings.Diagrams.Title>? Titles { get; set; }
  
  public Collection<DocumentModel.Drawings.Diagrams.Description>? Descriptions { get; set; }
  
  public DocumentModel.Drawings.Diagrams.CategoryList? CategoryList { get; set; }
  
  public DocumentModel.Drawings.Diagrams.SampleData? SampleData { get; set; }
  
  public DocumentModel.Drawings.Diagrams.StyleData? StyleData { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ColorData? ColorData { get; set; }
  
  public DocumentModel.Drawings.Diagrams.LayoutNode? LayoutNode { get; set; }
  
  public DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get; set; }
  
}
