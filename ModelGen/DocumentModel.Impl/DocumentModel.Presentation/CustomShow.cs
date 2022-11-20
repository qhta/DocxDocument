namespace DocumentModel.Presentation;

/// <summary>
/// Custom Show.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideList))]
public class CustomShow: ICustomShow
{
  /// <summary>
  /// Custom Show Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Show ID
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Presentation Slides.
  /// </summary>
  public ISlideList? SlideList
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
