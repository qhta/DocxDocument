namespace DocumentModel.Vml;

/// <summary>
///   Rule Set.
/// </summary>
public class Rules: ModelElementCollection<Rule, DXVO.Rules, DXVO.Rule>
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
}