namespace DocumentModel.Vml.Office;


/// <summary>
///   Shape ID Map.
/// </summary>
public partial class ShapeIdMap
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Shape IDs
  /// </summary>
  [SchemaAttr("data")]
  public String? Data { get; set; }
  
}
