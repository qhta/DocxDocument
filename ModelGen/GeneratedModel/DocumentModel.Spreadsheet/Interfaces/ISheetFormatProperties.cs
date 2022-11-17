namespace DocumentModel.Spreadsheet;

public interface ISheetFormatProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? BaseColumnWidth { get ; set; }
  
  public double? DefaultColumnWidth { get ; set; }
  
  public double? DefaultRowHeight { get ; set; }
  
  public bool? CustomHeight { get ; set; }
  
  public bool? ZeroHeight { get ; set; }
  
  public bool? ThickTop { get ; set; }
  
  public bool? ThickBottom { get ; set; }
  
  public byte? OutlineLevelRow { get ; set; }
  
  public byte? OutlineLevelColumn { get ; set; }
  
  public double? DyDescent { get ; set; }
  
}
