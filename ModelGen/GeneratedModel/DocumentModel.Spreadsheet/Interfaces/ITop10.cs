namespace DocumentModel.Spreadsheet;

public interface ITop10 // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? Top { get ; set; }
  
  public bool? Percent { get ; set; }
  
  public double? Val { get ; set; }
  
  public double? FilterValue { get ; set; }
  
}
