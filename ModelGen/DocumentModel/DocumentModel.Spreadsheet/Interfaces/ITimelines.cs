namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Timelines Class.
/// </summary>
public interface ITimelines // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITimeline>? Timelines { get ; set; }
  
}
