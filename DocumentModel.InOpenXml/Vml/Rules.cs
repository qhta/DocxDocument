namespace DocumentModel.Vml;

/// <summary>
///   Rule Set.
/// </summary>
public interface Rules: IElementCollection<Rule>
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
}