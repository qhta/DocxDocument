namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Style.
/// </summary>
public interface ITableCellStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Borders.
  /// </summary>
  public ITableCellBorders? TableCellBorders { get ; set; }
  
}
