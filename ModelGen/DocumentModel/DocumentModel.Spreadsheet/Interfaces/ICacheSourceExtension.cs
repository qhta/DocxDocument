namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSourceExtension Class.
/// </summary>
public interface ICacheSourceExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ISourceConnection? SourceConnection { get ; set; }
  
}
