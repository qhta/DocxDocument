namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Wireframe.
/// </summary>
public partial class Wireframe: ModelElement<DXDC.Wireframe>
{
  public Wireframe(): base(){ }
  
  public Wireframe(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Wireframe(DXDC.Wireframe openXmlElement): base(openXmlElement) { }
  
}
