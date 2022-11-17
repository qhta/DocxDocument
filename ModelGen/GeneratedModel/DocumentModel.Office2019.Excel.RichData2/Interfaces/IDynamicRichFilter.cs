namespace DocumentModel.Office2019.Excel.RichData2;

public interface IDynamicRichFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Key { get ; set; }
  
  public DynamicFilter? Type { get ; set; }
  
  public double? Val { get ; set; }
  
  public double? MaxVal { get ; set; }
  
  public DateTime? ValIso { get ; set; }
  
  public DateTime? MaxValIso { get ; set; }
  
}
