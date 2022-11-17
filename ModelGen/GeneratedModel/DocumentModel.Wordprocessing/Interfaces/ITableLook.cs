namespace DocumentModel.Wordprocessing;

public interface ITableLook // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public IHexBinaryValue? Val { get ; set; }
  
  public bool? FirstRow { get ; set; }
  
  public bool? LastRow { get ; set; }
  
  public bool? FirstColumn { get ; set; }
  
  public bool? LastColumn { get ; set; }
  
  public bool? NoHorizontalBand { get ; set; }
  
  public bool? NoVerticalBand { get ; set; }
  
}
