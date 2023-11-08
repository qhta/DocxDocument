namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the AllowPNG Class.
/// </summary>
public partial class AllowPNG: ModelElement<DXW.AllowPNG>
{
  public AllowPNG(): base(){ }
  
  public AllowPNG(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AllowPNG(DXW.AllowPNG openXmlElement): base(openXmlElement) { }
  
}
