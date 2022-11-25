namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineReference Class.
/// </summary>
public interface ITimelineReference // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
}
