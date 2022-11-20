namespace DocumentModel.Office.SpreadSheetML.Y2021.ExtLinks2021;

/// <summary>
/// Defines the ExternalBookAlternateUrls Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.SpreadSheetML.Y2021.ExtLinks2021.IAbsoluteUrlAlternateUrl))]
[ChildElementInfo(typeof(DocumentModel.Office.SpreadSheetML.Y2021.ExtLinks2021.IRelativeUrlAlternateUrl))]
public class ExternalBookAlternateUrls: IExternalBookAlternateUrls
{
  /// <summary>
  /// driveId, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? DriveId
  {
    get;
    set;
  }
  
  /// <summary>
  /// itemId, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? ItemId
  {
    get;
    set;
  }
  
  /// <summary>
  /// AbsoluteUrlAlternateUrl.
  /// </summary>
  public IAbsoluteUrlAlternateUrl? AbsoluteUrlAlternateUrl
  {
    get;
    set;
  }
  
  /// <summary>
  /// RelativeUrlAlternateUrl.
  /// </summary>
  public IRelativeUrlAlternateUrl? RelativeUrlAlternateUrl
  {
    get;
    set;
  }
  
}
