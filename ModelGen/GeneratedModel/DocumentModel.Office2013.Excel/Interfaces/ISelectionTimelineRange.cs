namespace DocumentModel.Office2013.Excel;

public interface ISelectionTimelineRange // : DocumentFormat.OpenXml.Office2013.Excel.TimelineRange
{
  public DateTime? StartDate { get ; set; }
  
  public DateTime? EndDate { get ; set; }
  
}
