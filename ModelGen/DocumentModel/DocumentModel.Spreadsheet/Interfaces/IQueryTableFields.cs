namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query table fields.
/// </summary>
public interface IQueryTableFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IQueryTableField>? QueryTableFields { get ; set; }
  
}
