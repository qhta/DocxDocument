namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Else.
/// </summary>
public class DiagramChooseElse
{
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }

  public Algorithm? Algorithm { get; set; }

  public Shape? Shape { get; set; }

  public PresentationOf? PresentationOf { get; set; }

  public Constraints? Constraints { get; set; }

  public RuleList? RuleList { get; set; }

  public ForEach? ForEach { get; set; }

  public LayoutNode? LayoutNode { get; set; }

  public Choose? Choose { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}