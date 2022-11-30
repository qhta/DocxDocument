namespace DocumentModel.Spreadsheet;

/// <summary>
/// Deleted Fields.
/// </summary>
public interface IQueryTableDeletedFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Deleted Fields Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IDeletedField>? DeletedFields { get ; set; }
  
}
