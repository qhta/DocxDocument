namespace DocumentModel.Drawing;

/// <summary>
/// Font.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISupplementalFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILatinFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEastAsianFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IComplexScriptFont))]
public class Fonts: IFonts
{
  /// <summary>
  /// Latin Font.
  /// </summary>
  public ILatinFont? LatinFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public IEastAsianFont? EastAsianFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public IComplexScriptFont? ComplexScriptFont
  {
    get;
    set;
  }
  
}
