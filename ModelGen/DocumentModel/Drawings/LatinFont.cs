namespace DocumentModel.Drawings;


/// <summary>
///   Latin Font.
/// </summary>
public partial class LatinFont: ModelElement<DXD.LatinFont>
{
  public LatinFont(): base(){ }
  
  public LatinFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LatinFont(DXD.LatinFont openXmlElement): base(openXmlElement) { }
  
}
