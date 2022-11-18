namespace DocumentModel.Spreadsheet;

/// <summary>
/// Web Publishing Item.
/// </summary>
public interface IWebPublishItem // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Id
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// Destination Bookmark
  /// </summary>
  public string? DivId { get ; set; }
  
  /// <summary>
  /// Web Source Type
  /// </summary>
  public WebSource? SourceType { get ; set; }
  
  /// <summary>
  /// Source Id
  /// </summary>
  public string? SourceRef { get ; set; }
  
  /// <summary>
  /// Source Object Name
  /// </summary>
  public string? SourceObject { get ; set; }
  
  /// <summary>
  /// Destination File Name
  /// </summary>
  public string? DestinationFile { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public string? Title { get ; set; }
  
  /// <summary>
  /// Automatically Publish
  /// </summary>
  public bool? AutoRepublish { get ; set; }
  
}
