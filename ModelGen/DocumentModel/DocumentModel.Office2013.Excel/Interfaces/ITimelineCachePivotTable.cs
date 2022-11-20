namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineCachePivotTable Class.
/// </summary>
public interface ITimelineCachePivotTable // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// tabId, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? TabId { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get ; set; }
  
}
