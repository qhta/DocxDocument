namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFieldExtension Class.
/// </summary>
public interface CacheFieldExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public CacheField? CacheField { get ; set; }
  
  public CachedUniqueNames? CachedUniqueNames { get ; set; }
  
}
