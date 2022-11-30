namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the Timelines Class.
/// </summary>
public interface ITimelines // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.Excel.ITimeline>? Timelines { get ; set; }
  
}
