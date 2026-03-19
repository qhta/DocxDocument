namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Layout Node.
/// </summary>
[OpenXmlType(typeof(DXDD.LayoutNode))]
/// <summary>
/// Represents the Layout Node.
/// </summary>
public class LayoutNode: ModelElement<DXDD.LayoutNode>
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Style Label
  /// </summary>
  public string? StyleLabel { get; set; }
  /// <summary>
  ///   Child Order
  /// </summary>
  public ChildOrder? ChildOrder { get; set; }
  /// <summary>
  ///   Move With
  /// </summary>
  public string? MoveWith { get; set; }
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
  /// Variable List.
  /// </summary>
  public VariableList? VariableList { get; set; }
  /// <summary>
  /// For Each.
  /// </summary>
  public ForEach? ForEach { get; set; }
  /// <summary>
  /// Child Layout Node.
  /// </summary>
  public LayoutNode? ChildLayoutNode { get; set; }
  /// <summary>
  /// Choose.
  /// </summary>
  public Choose? Choose { get; set; }
  /// <summary>
  /// Extension List.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}

