namespace DocumentModel.Spreadsheet;

/// <summary>
/// Deleted Fields.
/// </summary>
public interface IQueryTableDeletedFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Deleted Fields Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IDeletedField>? DeletedFields { get ; set; }
  
}
