namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TextStyles Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ITitleStyle))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBodyStyle))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IOtherStyle))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class TextStyles: ITextStyles
{
  /// <summary>
  /// Slide Master Title Text Style.
  /// </summary>
  public DocumentModel.Presentation.ITitleStyle? TitleStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Slide Master Body Text Style.
  /// </summary>
  public IBodyStyle? BodyStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Slide Master Other Text Style.
  /// </summary>
  public IOtherStyle? OtherStyle
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
