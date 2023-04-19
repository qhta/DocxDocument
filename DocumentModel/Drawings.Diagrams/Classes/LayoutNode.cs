namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Layout Node.
/// </summary>
public class LayoutNode: ModelElement
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
  public ChildOrderKind? ChildOrder { get; set; }

  /// <summary>
  ///   Move With
  /// </summary>
  public string? MoveWith { get; set; }

  public Algorithm? Algorithm { get; set; }

  public Shape? Shape { get; set; }

  public PresentationOf? PresentationOf { get; set; }

  public Constraints? Constraints { get; set; }

  public RuleList? RuleList { get; set; }

  public VariableList? VariableList { get; set; }

  public ForEach? ForEach { get; set; }

  public LayoutNode? ChildLayoutNode { get; set; }

  public Choose? Choose { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}