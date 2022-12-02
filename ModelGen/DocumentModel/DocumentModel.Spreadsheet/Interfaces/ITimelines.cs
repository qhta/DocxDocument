namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Timelines Class.
/// </summary>
public interface ITimelines // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ITimeline>? Timelines { get ; set; }
  
}
