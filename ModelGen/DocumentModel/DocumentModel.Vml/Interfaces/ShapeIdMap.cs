namespace DocumentModel.Vml;

/// <summary>
/// Shape ID Map.
/// </summary>
public interface ShapeIdMap
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  public String? Data { get ; set; }
  
}
