namespace DocumentModel.Wordprocessing;


/// <summary>
///   Prevent Modification of Themes Part.
/// </summary>
public partial class StyleLockThemesPart: ModelElement<DXW.StyleLockThemesPart>
{
  public StyleLockThemesPart(): base(){ }
  
  public StyleLockThemesPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleLockThemesPart(DXW.StyleLockThemesPart openXmlElement): base(openXmlElement) { }
  
}
