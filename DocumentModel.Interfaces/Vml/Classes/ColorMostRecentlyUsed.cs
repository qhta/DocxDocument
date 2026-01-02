namespace DocumentModel.Vml;

/// <summary>
///   Most Recently Used Colors.
/// </summary>
public class ColorMostRecentlyUsed: ModelElement
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