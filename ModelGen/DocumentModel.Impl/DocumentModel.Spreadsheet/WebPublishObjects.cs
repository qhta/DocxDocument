namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebPublishObjects Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IWebPublishObject))]
public class WebPublishObjects: IWebPublishObjects
{
  /// <summary>
  /// Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
