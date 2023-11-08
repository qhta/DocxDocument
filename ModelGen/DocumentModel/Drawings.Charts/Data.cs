namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Cannot Be Changed.
/// </summary>
public partial class Data: ModelElement<DXDC.Data>
{
  public Data(): base(){ }
  
  public Data(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Data(DXDC.Data openXmlElement): base(openXmlElement) { }
  
}
