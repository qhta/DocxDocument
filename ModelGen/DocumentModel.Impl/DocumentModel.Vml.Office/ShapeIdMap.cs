namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape ID Map.
/// </summary>
public class ShapeIdMap: IShapeIdMap
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  public string? Data
  {
    get;
    set;
  }
  
}
