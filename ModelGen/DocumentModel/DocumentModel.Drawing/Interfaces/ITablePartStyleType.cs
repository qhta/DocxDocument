namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TablePartStyleType Class.
/// </summary>
public interface ITablePartStyleType // : DocumentModel.ITypedOpenXmlCompositeElement
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
