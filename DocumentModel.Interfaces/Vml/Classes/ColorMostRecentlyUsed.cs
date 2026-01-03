namespace DocumentModel.Vml;

/// <summary>
///   Most Recently Used Colors.
/// </summary>
public interface ColorMostRecentlyUsed: IModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  /// <summary>
  ///   Recent colors
  /// </summary>
  public string? Colors { get; set; }
}