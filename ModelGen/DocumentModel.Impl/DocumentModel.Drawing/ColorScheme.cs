namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ColorScheme Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IDark1Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILight1Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IDark2Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILight2Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAccent1Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAccent2Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAccent3Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAccent4Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAccent5Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAccent6Color))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlink))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFollowedHyperlinkColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class ColorScheme: IColorScheme
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Dark 1.
  /// </summary>
  public IDark1Color? Dark1Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  public ILight1Color? Light1Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  public IDark2Color? Dark2Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  public ILight2Color? Light2Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  public IAccent1Color? Accent1Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  public IAccent2Color? Accent2Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  public IAccent3Color? Accent3Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  public IAccent4Color? Accent4Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  public IAccent5Color? Accent5Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  public IAccent6Color? Accent6Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  public DocumentModel.Drawing.IHyperlink? Hyperlink
  {
    get;
    set;
  }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  public IFollowedHyperlinkColor? FollowedHyperlinkColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
