namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape ID Map.
/// </summary>
public interface IShapeIdMap // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  public System.String? Data { get ; set; }
  
}
