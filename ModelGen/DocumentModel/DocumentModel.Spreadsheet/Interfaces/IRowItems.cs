namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowItems Class.
/// </summary>
public interface IRowItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items in a Row Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IRowItem>? RowItems { get ; set; }
  
}
