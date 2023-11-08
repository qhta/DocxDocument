namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Height.
/// </summary>
public partial class Height: ModelElement<DXDC.Height>
{
  public Height(): base(){ }
  
  public Height(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Height(DXDC.Height openXmlElement): base(openXmlElement) { }
  
}
