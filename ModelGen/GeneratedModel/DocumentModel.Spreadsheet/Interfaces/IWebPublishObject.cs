namespace DocumentModel.Spreadsheet;

/// <summary>
/// Web Publishing Object.
/// </summary>
public interface IWebPublishObject // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Id
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// Div Id
  /// </summary>
  public string? DivId { get ; set; }
  
  /// <summary>
  /// Source Object
  /// </summary>
  public string? SourceObject { get ; set; }
  
  /// <summary>
  /// Destination File
  /// </summary>
  public string? DestinationFile { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public string? Title { get ; set; }
  
  /// <summary>
  /// Auto Republish
  /// </summary>
  public bool? AutoRepublish { get ; set; }
  
}
