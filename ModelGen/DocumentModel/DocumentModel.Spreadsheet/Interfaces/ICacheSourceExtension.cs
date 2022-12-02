namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSourceExtension Class.
/// </summary>
public interface ICacheSourceExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Spreadsheet.ISourceConnection? SourceConnection { get ; set; }
  
}
