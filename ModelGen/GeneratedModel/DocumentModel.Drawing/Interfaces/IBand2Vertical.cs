namespace DocumentModel.Drawing;

public interface IBand2Vertical // : DocumentFormat.OpenXml.Drawing.TablePartStyleType
{
  public ITableCellTextStyle? TableCellTextStyle { get ; set; }
  
  public ITableCellStyle? TableCellStyle { get ; set; }
  
}
