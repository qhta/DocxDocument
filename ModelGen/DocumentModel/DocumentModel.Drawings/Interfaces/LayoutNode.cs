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
  public ChildOrderKind? ChildOrder { get ; set; }
  
  /// <summary>
  /// Move With
  /// </summary>
  public String? MoveWith { get ; set; }
  
  public Algorithm? Algorithm { get ; set; }
  
  public Shape? Shape { get ; set; }
  
  public PresentationOf? PresentationOf { get ; set; }
  
  public Constraints? Constraints { get ; set; }
  
  public RuleList? RuleList { get ; set; }
  
  public VariableList? VariableList { get ; set; }
  
  public ForEach? ForEach { get ; set; }
  
  public LayoutNode? ChildLayoutNode { get ; set; }
  
  public Choose? Choose { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
