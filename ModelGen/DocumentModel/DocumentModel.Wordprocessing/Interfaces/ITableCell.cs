namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell.
/// </summary>
public interface ITableCell // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Properties.
  /// </summary>
  public ITableCellProperties? TableCellProperties { get ; set; }
  
}
