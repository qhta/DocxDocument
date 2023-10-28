namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Layout Definition.
/// </summary>
public partial class LayoutDefinition
{
  
  /// <summary>
  ///   uniqueId
  /// </summary>
  public String? UniqueId { get; set; }
  
  
  /// <summary>
  ///   minVer
  /// </summary>
  public String? MinVersion { get; set; }
  
  
  /// <summary>
  ///   defStyle
  /// </summary>
  public String? DefaultStyle { get; set; }
  
  public DMDD.CategoryList? CategoryList { get; set; }
  
  public DMDD.SampleData? SampleData { get; set; }
  
  public DMDD.StyleData? StyleData { get; set; }
  
  public DMDD.ColorData? ColorData { get; set; }
  
  public DMDD.LayoutNode? LayoutNode { get; set; }
  
  public DMDD.DiagramDefinitionExtensionList? DiagramDefinitionExtensionList { get; set; }
  
}
