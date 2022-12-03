namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query table fields.
/// </summary>
public interface QueryTableFields // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Column Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<QueryTableField>? QueryTableFields { get ; set; }
  
}
