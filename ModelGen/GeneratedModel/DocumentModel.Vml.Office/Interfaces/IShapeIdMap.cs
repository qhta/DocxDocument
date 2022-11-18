namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape ID Map.
/// </summary>
public interface IShapeIdMap // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  public string? Data { get ; set; }
  
}
