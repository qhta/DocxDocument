namespace DocumentModel.Spreadsheet;

/// <summary>
/// Web Publishing Item.
/// </summary>
public interface IWebPublishItem // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Destination Bookmark
  /// </summary>
  public System.String? DivId { get ; set; }
  
  /// <summary>
  /// Web Source Type
  /// </summary>
  public DocumentModel.Spreadsheet.WebSourceKind? SourceType { get ; set; }
  
  /// <summary>
  /// Source Id
  /// </summary>
  public System.String? SourceRef { get ; set; }
  
  /// <summary>
  /// Source Object Name
  /// </summary>
  public System.String? SourceObject { get ; set; }
  
  /// <summary>
  /// Destination File Name
  /// </summary>
  public System.String? DestinationFile { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public System.String? Title { get ; set; }
  
  /// <summary>
  /// Automatically Publish
  /// </summary>
  public System.Boolean? AutoRepublish { get ; set; }
  
}
