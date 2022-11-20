namespace DocumentModel.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontCharSet))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontFamily))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmbedRegularFont))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmbedBoldFont))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmbedItalicFont))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmbedBoldItalicFont))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontSignature))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INotTrueType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPanose1Number))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPitch))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAltName))]
public class Font: IFont
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// AltName.
  /// </summary>
  public IAltName? AltName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  public IPanose1Number? Panose1Number
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontCharSet? FontCharSet
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontFamily? FontFamily
  {
    get;
    set;
  }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  public INotTrueType? NotTrueType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public IPitch? Pitch
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public IFontSignature? FontSignature
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public IEmbedRegularFont? EmbedRegularFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public IEmbedBoldFont? EmbedBoldFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public IEmbedItalicFont? EmbedItalicFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public IEmbedBoldItalicFont? EmbedBoldItalicFont
  {
    get;
    set;
  }
  
}
