namespace DocumentModel.Drawings;


/// <summary>
///   East Asian Font.
/// </summary>
public partial class EastAsianFont: ModelElement<DXD.EastAsianFont>
{
  public EastAsianFont(): base(){ }
  
  public EastAsianFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EastAsianFont(DXD.EastAsianFont openXmlElement): base(openXmlElement) { }
  
}
