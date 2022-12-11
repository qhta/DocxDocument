namespace DocumentModel.Drawings;

/// <summary>
/// For Each.
/// </summary>
public interface ForEach
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
  
  public Algorithm? Algorithm { get ; set; }
  
  public Shape? Shape { get ; set; }
  
  public PresentationOf? PresentationOf { get ; set; }
  
  public Constraints? Constraints { get ; set; }
  
  public RuleList? RuleList { get ; set; }
  
  public ForEach? ChildForEach { get ; set; }
  
  public LayoutNode? LayoutNode { get ; set; }
  
  public Choose? Choose { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
