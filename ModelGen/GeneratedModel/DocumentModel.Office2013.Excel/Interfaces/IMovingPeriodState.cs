namespace DocumentModel.Office2013.Excel;

public interface IMovingPeriodState // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public DateTime? ReferenceDateBegin { get ; set; }
  
  public MovingPeriodStep? ReferencePeriod { get ; set; }
  
  public uint? ReferenceMultiple { get ; set; }
  
  public MovingPeriodStep? MovingPeriod { get ; set; }
  
  public uint? MovingMultiple { get ; set; }
  
}
