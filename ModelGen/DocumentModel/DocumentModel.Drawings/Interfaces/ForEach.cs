namespace DocumentModel.Drawings;

/// <summary>
/// For Each.
/// </summary>
public interface ForEach // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<AxisKind>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<ElementKind>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<Boolean>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<Int32>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<UInt32>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<Int32>? Step { get ; set; }
  
  public Collection<Algorithm>? Algorithms { get ; set; }
  
  public Collection<Shape>? Shapes { get ; set; }
  
  public Collection<PresentationOf>? PresentationOfs { get ; set; }
  
  public Collection<Constraints>? Constraintses { get ; set; }
  
  public Collection<RuleList>? RuleLists { get ; set; }
  
  public Collection<ForEach>? ForEachs { get ; set; }
  
  public Collection<LayoutNode>? LayoutNodes { get ; set; }
  
  public Collection<Choose>? Chooses { get ; set; }
  
  public Collection<ExtensionList>? ExtensionLists { get ; set; }
  
}
