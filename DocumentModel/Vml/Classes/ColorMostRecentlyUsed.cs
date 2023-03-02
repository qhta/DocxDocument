namespace DocumentModel.Vml;

/// <summary>
///   Most Recently Used Colors.
/// </summary>
public record ColorMostRecentlyUsed
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   Recent colors
  /// </summary>
  public String? Colors { get; set; }
}