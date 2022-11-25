namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TablePartStyleType Class.
/// </summary>
public interface ITablePartStyleType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITableCellTextStyle? TableCellTextStyle { get ; set; }
  
  /// <summary>
  /// Table Cell Style.
  /// </summary>
  public DocumentModel.Drawing.ITableCellStyle? TableCellStyle { get ; set; }
  
}
