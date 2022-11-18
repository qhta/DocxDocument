namespace DocumentModel.Drawing;

/// <summary>
/// Whole Table.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCellTextStyle))]
public interface IWholeTable // : DocumentFormat.OpenXml.Drawing.TablePartStyleType
{
  /// <summary>
  /// Table Cell Text Style.
  /// </summary>
  public ITableCellTextStyle? TableCellTextStyle { get ; set; }
  
  /// <summary>
  /// Table Cell Style.
  /// </summary>
  public ITableCellStyle? TableCellStyle { get ; set; }
  
}
