namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   For Each.
/// </summary>
[OpenXmlType(typeof(DXDD.ForEach))]
/// <summary>
/// Represents the For Each.
/// </summary>
public class ForEach: ModelElement<DXDD.ForEach>
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Reference
  /// </summary>
  public string? Reference { get; set; }
  /// <summary>
  ///   Axis
  /// </summary>
  public ListOf<AxisType>? Axis { get; set; }
  /// <summary>
  ///   Data Point Type
  /// </summary>
  public ListOf<ElementType>? PointType { get; set; }
  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  public ListOf<Boolean>? HideLastTrans { get; set; }
  /// <summary>
  ///   Start
  /// </summary>
  public ListOf<Int32>? Start { get; set; }
  /// <summary>
  ///   Count
  /// </summary>
  public ListOf<UInt32>? Count { get; set; }
  /// <summary>
  ///   Step
  /// </summary>
  public ListOf<Int32>? Step { get; set; }
  /// <summary>
  /// Algorithm.
  /// </summary>
  public Algorithm? Algorithm { get; set; }
  /// <summary>
  /// Shape.
  /// </summary>
  public Shape? Shape { get; set; }
  /// <summary>
  /// Presentation Of.
  /// </summary>
  public PresentationOf? PresentationOf { get; set; }
  /// <summary>
  /// Constraints.
  /// </summary>
  public Constraints? Constraints { get; set; }
  /// <summary>
  /// Rule List.
  /// </summary>
  public RuleList? RuleList { get; set; }
  /// <summary>
  /// Child For Each.
  /// </summary>
  public ForEach? ChildForEach { get; set; }
  /// <summary>
  /// Layout Node.
  /// </summary>
  public LayoutNode? LayoutNode { get; set; }
  /// <summary>
  /// Choose.
  /// </summary>
  public Choose? Choose { get; set; }
  /// <summary>
  /// Extension List.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}

