namespace DocumentModel.Office2013.Excel;

public interface IPivotValueCellExtra // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? FormatIndex { get ; set; }
  
  public IHexBinaryValue? BackgroundColor { get ; set; }
  
  public IHexBinaryValue? ForegroundColor { get ; set; }
  
  public bool? Italic { get ; set; }
  
  public bool? Underline { get ; set; }
  
  public bool? Strikethrough { get ; set; }
  
  public bool? Bold { get ; set; }
  
}
