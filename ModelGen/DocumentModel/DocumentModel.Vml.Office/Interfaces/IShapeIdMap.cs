namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape ID Map.
/// </summary>
public interface IShapeIdMap // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  public String? Data { get ; set; }
  
}
