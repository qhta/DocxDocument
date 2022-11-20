namespace DocumentModel.Presentation;

/// <summary>
/// Embedded Font.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IFont))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IRegularFont))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBoldFont))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IItalicFont))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBoldItalicFont))]
public class EmbeddedFont: IEmbeddedFont
{
  /// <summary>
  /// Embedded Font Name.
  /// </summary>
  public DocumentModel.Presentation.IFont? Font
  {
    get;
    set;
  }
  
  /// <summary>
  /// Regular Embedded Font.
  /// </summary>
  public IRegularFont? RegularFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bold Embedded Font.
  /// </summary>
  public IBoldFont? BoldFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// Italic Embedded Font.
  /// </summary>
  public IItalicFont? ItalicFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bold Italic Embedded Font.
  /// </summary>
  public IBoldItalicFont? BoldItalicFont
  {
    get;
    set;
  }
  
}
