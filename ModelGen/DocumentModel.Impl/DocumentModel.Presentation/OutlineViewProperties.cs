namespace DocumentModel.Presentation;

/// <summary>
/// Outline View Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IOutlineViewSlideList))]
public class OutlineViewProperties: IOutlineViewProperties
{
  /// <summary>
  /// Common View Properties.
  /// </summary>
  public ICommonViewProperties? CommonViewProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Presentation Slides.
  /// </summary>
  public IOutlineViewSlideList? OutlineViewSlideList
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
