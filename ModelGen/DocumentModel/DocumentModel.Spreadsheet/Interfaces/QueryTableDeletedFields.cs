namespace DocumentModel.Spreadsheet;

/// <summary>
/// Deleted Fields.
/// </summary>
public interface QueryTableDeletedFields // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Deleted Fields Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<DeletedField>? DeletedFields { get ; set; }
  
}
