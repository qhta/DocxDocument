namespace DocumentModel.Drawing;

public interface ISoutheastCell // : DocumentFormat.OpenXml.Drawing.TablePartStyleType
{
  public ITableCellTextStyle? TableCellTextStyle { get ; set; }
  
  public ITableCellStyle? TableCellStyle { get ; set; }
  
}
