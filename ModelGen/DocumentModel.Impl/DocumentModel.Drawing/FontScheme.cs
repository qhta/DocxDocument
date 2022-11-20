namespace DocumentModel.Drawing;

/// <summary>
/// Font Scheme.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IMajorFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IMinorFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class FontScheme: IFontScheme
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
  /// Major Font.
  /// </summary>
  public IMajorFont? MajorFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  public IMinorFont? MinorFont
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
