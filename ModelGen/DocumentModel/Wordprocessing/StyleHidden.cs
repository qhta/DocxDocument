namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the glyph representing the end character of current table row shall not be displayed in the current document.
/// </summary>
public partial class StyleHidden: ModelElement<DXW.StyleHidden>
{
  public StyleHidden(): base(){ }
  
  public StyleHidden(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleHidden(DXW.StyleHidden openXmlElement): base(openXmlElement) { }
  
}
