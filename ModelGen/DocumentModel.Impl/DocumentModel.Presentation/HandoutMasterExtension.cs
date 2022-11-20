namespace DocumentModel.Presentation;

/// <summary>
/// Defines the HandoutMasterExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.ISlideGuideList))]
public class HandoutMasterExtension: IHandoutMasterExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
