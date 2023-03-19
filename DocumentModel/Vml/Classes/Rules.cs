namespace DocumentModel.Vml;

/// <summary>
///   Rule Set.
/// </summary>
public class Rules: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  public Collection<Rule>? Items { get; set; }
}