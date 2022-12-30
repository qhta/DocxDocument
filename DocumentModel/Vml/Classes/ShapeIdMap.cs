namespace DocumentModel.Vml;

/// <summary>
/// Shape ID Map.
/// </summary>
public partial class ShapeIdMap
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  public String? Data { get; set; }
  
}
