namespace DocumentModel.Vml;

/// <summary>
///   Rule Set.
/// </summary>
public interface Rules: IModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  public Collection<Rule>? Items { get; set; }
}