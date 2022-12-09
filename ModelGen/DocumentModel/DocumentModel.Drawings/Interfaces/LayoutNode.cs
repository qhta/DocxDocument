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
  
  public Collection<Algorithm>? Algorithms { get ; set; }
  
  public Collection<Shape2>? Shapes { get ; set; }
  
  public Collection<PresentationOf>? PresentationOfs { get ; set; }
  
  public Collection<Constraints>? Constraintses { get ; set; }
  
  public Collection<RuleList>? RuleLists { get ; set; }
  
  public Collection<VariableList>? VariableLists { get ; set; }
  
  public Collection<ForEach>? ForEachs { get ; set; }
  
  public Collection<LayoutNode>? LayoutNodes { get ; set; }
  
  public Collection<Choose>? Chooses { get ; set; }
  
  public Collection<ExtensionList1>? ExtensionLists { get ; set; }
  
}
