namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineStyleElement Class.
/// </summary>
public interface ITimelineStyleElement // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public TimelineStyleType? Type { get ; set; }
  
  /// <summary>
  /// dxfId, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? FormatId { get ; set; }
  
}
