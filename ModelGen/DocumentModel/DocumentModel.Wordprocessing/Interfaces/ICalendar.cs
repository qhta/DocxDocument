namespace DocumentModel.Wordprocessing;

/// <summary>
/// Date Picker Calendar Type.
/// </summary>
public interface ICalendar // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Calendar Type Value
  /// </summary>
  public DocumentModel.Wordprocessing.CalendarValues? Val { get ; set; }
  
}
