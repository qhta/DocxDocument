namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Bubble.
/// </summary>
public partial class Bubble3D: ModelElement<DXDC.Bubble3D>
{
  public Bubble3D(): base(){ }
  
  public Bubble3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Bubble3D(DXDC.Bubble3D openXmlElement): base(openXmlElement) { }
  
}
