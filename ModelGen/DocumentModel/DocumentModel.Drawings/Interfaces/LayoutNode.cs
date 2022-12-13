namespace DocumentModel.Drawings;

/// <summary>
/// Layout Node.
/// </summary>
public interface LayoutNode
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Style Label
  /// </summary>
  public String? StyleLabel { get ; set; }
  
  /// <summary>
  /// Child Order
  /// </summary>
  public DocumentModel.Drawings.ChildOrderKind? ChildOrder { get ; set; }
  
  /// <summary>
  /// Move With
  /// </summary>
  public String? MoveWith { get ; set; }
  
  public DocumentModel.Drawings.Algorithm? Algorithm { get ; set; }
  
  public DocumentModel.Drawings.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.PresentationOf? PresentationOf { get ; set; }
  
  public DocumentModel.Drawings.Constraints? Constraints { get ; set; }
  
  public DocumentModel.Drawings.RuleList? RuleList { get ; set; }
  
  public DocumentModel.Drawings.VariableList? VariableList { get ; set; }
  
  public DocumentModel.Drawings.ForEach? ForEach { get ; set; }
  
  public DocumentModel.Drawings.LayoutNode? ChildLayoutNode { get ; set; }
  
  public DocumentModel.Drawings.Choose? Choose { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
