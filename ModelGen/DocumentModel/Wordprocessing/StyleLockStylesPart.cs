namespace DocumentModel.Wordprocessing;


/// <summary>
///   Prevent Replacement of Styles Part.
/// </summary>
public partial class StyleLockStylesPart: ModelElement<DXW.StyleLockStylesPart>
{
  public StyleLockStylesPart(): base(){ }
  
  public StyleLockStylesPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleLockStylesPart(DXW.StyleLockStylesPart openXmlElement): base(openXmlElement) { }
  
}
