namespace DocumentModel.Drawing;

public interface ILastColumn // : DocumentFormat.OpenXml.Drawing.TablePartStyleType
{
  public ITableCellTextStyle? TableCellTextStyle { get ; set; }
  
  public ITableCellStyle? TableCellStyle { get ; set; }
  
}
