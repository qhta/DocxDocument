namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFields Class.
/// </summary>
public interface CacheFields // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<CacheField>? CacheFields { get ; set; }
  
}
