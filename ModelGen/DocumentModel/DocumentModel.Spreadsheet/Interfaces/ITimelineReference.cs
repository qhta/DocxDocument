namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TimelineReference Class.
/// </summary>
public interface ITimelineReference // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get ; set; }
  
}
