namespace DocumentModel.Drawings;


/// <summary>
///   This element represents an alpha floor effect.
/// </summary>
public partial class AlphaFloor: ModelElement<DXD.AlphaFloor>
{
  public AlphaFloor(): base(){ }
  
  public AlphaFloor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlphaFloor(DXD.AlphaFloor openXmlElement): base(openXmlElement) { }
  
}
