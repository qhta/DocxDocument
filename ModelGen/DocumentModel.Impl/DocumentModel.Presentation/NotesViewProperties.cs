namespace DocumentModel.Presentation;

/// <summary>
/// Notes View Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class NotesViewProperties: INotesViewProperties
{
  /// <summary>
  /// Common Slide View Properties.
  /// </summary>
  public ICommonSlideViewProperties? CommonSlideViewProperties
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
