namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnItems Class.
/// </summary>
public interface IColumnItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IRowItem>? RowItems { get ; set; }
  
}
