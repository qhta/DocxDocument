namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Height Mode.
/// </summary>
public partial class HeightMode: ModelElement<DXDC.HeightMode>
{
  public HeightMode(): base(){ }
  
  public HeightMode(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeightMode(DXDC.HeightMode openXmlElement): base(openXmlElement) { }
  
}
