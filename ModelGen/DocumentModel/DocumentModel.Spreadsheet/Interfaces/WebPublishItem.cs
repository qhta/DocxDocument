namespace DocumentModel.Spreadsheet;

/// <summary>
/// Web Publishing Item.
/// </summary>
public interface WebPublishItem // : System.Boolean
{
  /// <summary>
  /// Id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Destination Bookmark
  /// </summary>
  public String? DivId { get ; set; }
  
  /// <summary>
  /// Web Source Type
  /// </summary>
  public WebSourceKind? SourceType { get ; set; }
  
  /// <summary>
  /// Source Id
  /// </summary>
  public String? SourceRef { get ; set; }
  
  /// <summary>
  /// Source Object Name
  /// </summary>
  public String? SourceObject { get ; set; }
  
  /// <summary>
  /// Destination File Name
  /// </summary>
  public String? DestinationFile { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public String? Title { get ; set; }
  
  /// <summary>
  /// Automatically Publish
  /// </summary>
  public Boolean? AutoRepublish { get ; set; }
  
}
