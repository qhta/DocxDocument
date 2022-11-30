namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowItems Class.
/// </summary>
public interface IRowItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items in a Row Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IRowItem>? RowItems { get ; set; }
  
}
