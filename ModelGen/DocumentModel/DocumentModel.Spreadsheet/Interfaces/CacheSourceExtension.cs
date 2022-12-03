namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSourceExtension Class.
/// </summary>
public interface CacheSourceExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public SourceConnection? SourceConnection { get ; set; }
  
}
