namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Layout Node.
/// </summary>
public partial class LayoutNode
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// Style Label
  /// </summary>
  public String? StyleLabel { get; set; }
  
  /// <summary>
  /// Child Order
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ChildOrderKind? ChildOrder { get; set; }
  
  /// <summary>
  /// Move With
  /// </summary>
  public String? MoveWith { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Algorithm? Algorithm { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Shape? Shape { get; set; }
  
  public DocumentModel.Drawings.Diagrams.PresentationOf? PresentationOf { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Constraints? Constraints { get; set; }
  
  public DocumentModel.Drawings.Diagrams.RuleList? RuleList { get; set; }
  
  public DocumentModel.Drawings.Diagrams.VariableList? VariableList { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ForEach? ForEach { get; set; }
  
  public DocumentModel.Drawings.Diagrams.LayoutNode? ChildLayoutNode { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Choose? Choose { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
