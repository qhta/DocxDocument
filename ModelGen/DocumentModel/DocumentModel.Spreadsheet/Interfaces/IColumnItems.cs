namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnItems Class.
/// </summary>
public interface IColumnItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Item Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IRowItem>? RowItems { get ; set; }
  
}
