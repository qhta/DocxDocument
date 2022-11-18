namespace DocumentModel.Spreadsheet;

/// <summary>
/// Header.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IReviewedList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISheetIdMap))]
public interface IHeader // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// GUID
  /// </summary>
  public string? Guid { get ; set; }
  
  /// <summary>
  /// Date Time
  /// </summary>
  public DateTime? DateTime { get ; set; }
  
  /// <summary>
  /// Last Sheet Id
  /// </summary>
  public uint? MaxSheetId { get ; set; }
  
  /// <summary>
  /// User Name
  /// </summary>
  public string? UserName { get ; set; }
  
  /// <summary>
  /// Relationship ID
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Minimum Revision Id
  /// </summary>
  public uint? MinRevisionId { get ; set; }
  
  /// <summary>
  /// Max Revision Id
  /// </summary>
  public uint? MaxRevisionId { get ; set; }
  
  /// <summary>
  /// Sheet Id Map.
  /// </summary>
  public ISheetIdMap? SheetIdMap { get ; set; }
  
  /// <summary>
  /// Reviewed List.
  /// </summary>
  public IReviewedList? ReviewedList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
