namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the font size which shall be applied to all noncomplex script characters in the contents of this run when displayed. The font sizes specified by this element’s val attribute are expressed as half-point values.
/// </summary>
public partial class FontSize: ModelElement<DXW.FontSize>
{
  public FontSize(): base(){ }
  
  public FontSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontSize(DXW.FontSize openXmlElement): base(openXmlElement) { }
  
}
