namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Else.
/// </summary>
[OpenXmlType(typeof(DXDD.DiagramChooseElse))]
/// <summary>
/// Represents the Diagram Choose Else.
/// </summary>
public class DiagramChooseElse: ModelElement<DXDD.DiagramChooseElse>
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
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
  /// For Each.
  /// </summary>
  public ForEach? ForEach { get; set; }
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

