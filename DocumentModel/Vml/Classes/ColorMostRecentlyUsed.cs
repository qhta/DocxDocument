namespace DocumentModel.Vml;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public partial class ColorMostRecentlyUsed
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  public String? Colors { get; set; }
  
}
