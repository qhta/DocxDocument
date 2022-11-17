namespace DocumentModel.Drawing;

public interface IFirstColumn // : DocumentFormat.OpenXml.Drawing.TablePartStyleType
{
  public ITableCellTextStyle? TableCellTextStyle { get ; set; }

  public ITableCellStyle? TableCellStyle { get ; set; }

}
