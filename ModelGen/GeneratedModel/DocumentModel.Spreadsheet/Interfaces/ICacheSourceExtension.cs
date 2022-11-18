namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSourceExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISourceConnection))]
public interface ICacheSourceExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
