namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the font size which shall be applied to all complex script characters in the contents of this run when displayed. The font sizes specified by this element’s val attribute are expressed as half-point values.
/// </summary>
public partial class FontSizeComplexScript: ModelElement<DXW.FontSizeComplexScript>
{
  public FontSizeComplexScript(): base(){ }
  
  public FontSizeComplexScript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontSizeComplexScript(DXW.FontSizeComplexScript openXmlElement): base(openXmlElement) { }
  
}
