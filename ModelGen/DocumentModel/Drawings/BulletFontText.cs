namespace DocumentModel.Drawings;


/// <summary>
///   Follow text.
/// </summary>
public partial class BulletFontText: ModelElement<DXD.BulletFontText>
{
  public BulletFontText(): base(){ }
  
  public BulletFontText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BulletFontText(DXD.BulletFontText openXmlElement): base(openXmlElement) { }
  
}
