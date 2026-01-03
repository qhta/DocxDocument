namespace DocumentModel.Vml;

/// <summary>
///   Complex.
/// </summary>
public interface Complex: IModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
}