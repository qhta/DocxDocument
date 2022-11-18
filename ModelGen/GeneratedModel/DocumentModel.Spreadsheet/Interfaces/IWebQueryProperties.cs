namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebQueryProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITables))]
public interface IWebQueryProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// XML Source
  /// </summary>
  public bool? XmlSource { get ; set; }
  
  /// <summary>
  /// Import XML Source Data
  /// </summary>
  public bool? SourceData { get ; set; }
  
  /// <summary>
  /// Parse PRE
  /// </summary>
  public bool? ParsePreTag { get ; set; }
  
  /// <summary>
  /// Consecutive Delimiters
  /// </summary>
  public bool? Consecutive { get ; set; }
  
  /// <summary>
  /// Use First Row
  /// </summary>
  public bool? FirstRow { get ; set; }
  
  /// <summary>
  /// Created in Excel 97
  /// </summary>
  public bool? CreatedInExcel97 { get ; set; }
  
  /// <summary>
  /// Dates as Text
  /// </summary>
  public bool? TextDates { get ; set; }
  
  /// <summary>
  /// Refreshed in Excel 2000
  /// </summary>
  public bool? RefreshedInExcel2000 { get ; set; }
  
  /// <summary>
  /// URL
  /// </summary>
  public string? Url { get ; set; }
  
  /// <summary>
  /// Web Post
  /// </summary>
  public string? Post { get ; set; }
  
  /// <summary>
  /// HTML Tables Only
  /// </summary>
  public bool? HtmlTables { get ; set; }
  
  /// <summary>
  /// HTML Formatting Handling
  /// </summary>
  public HtmlFormatting? HtmlFormat { get ; set; }
  
  /// <summary>
  /// Edit Query URL
  /// </summary>
  public string? EditPage { get ; set; }
  
  /// <summary>
  /// Tables.
  /// </summary>
  public ITables? Tables { get ; set; }
  
}
