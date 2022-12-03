namespace DocumentModel.Vml;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public interface ColorMostRecentlyUsed // : System.Boolean
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  public String? Colors { get ; set; }
  
}
