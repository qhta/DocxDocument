namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerCachePivotTable Class.
/// </summary>
public interface ISlicerCachePivotTable // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// tabId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? TabId { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name { get ; set; }
  
}
