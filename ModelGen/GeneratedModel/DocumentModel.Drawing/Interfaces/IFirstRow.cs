namespace DocumentModel.Drawing;

public interface IFirstRow // : DocumentFormat.OpenXml.Drawing.TablePartStyleType
{
  public ITableCellTextStyle? TableCellTextStyle { get ; set; }

  public ITableCellStyle? TableCellStyle { get ; set; }

}
