namespace DocumentModel.Drawing;

/// <summary>
/// Major Font.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISupplementalFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILatinFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEastAsianFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IComplexScriptFont))]
public interface IMajorFont // : DocumentFormat.OpenXml.Drawing.FontCollectionType
{
  /// <summary>
  /// Latin Font.
  /// </summary>
  public ILatinFont? LatinFont { get ; set; }
  
  /// <summary>
  /// East Asian Font.
  /// </summary>
  public IEastAsianFont? EastAsianFont { get ; set; }
  
  /// <summary>
  /// Complex Script Font.
  /// </summary>
  public IComplexScriptFont? ComplexScriptFont { get ; set; }
  
}
