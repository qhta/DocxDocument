namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   For Each.
/// </summary>
public record ForEach
{
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Reference
  /// </summary>
  public String? Reference { get; set; }

  /// <summary>
  ///   Axis
  /// </summary>
  public ListOf<AxisKind>? Axis { get; set; }

  /// <summary>
  ///   Data Point Type
  /// </summary>
  public ListOf<ElementKind>? PointType { get; set; }

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

  public Algorithm? Algorithm { get; set; }

  public Shape? Shape { get; set; }

  public PresentationOf? PresentationOf { get; set; }

  public Constraints? Constraints { get; set; }

  public RuleList? RuleList { get; set; }

  public ForEach? ChildForEach { get; set; }

  public LayoutNode? LayoutNode { get; set; }

  public Choose? Choose { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}