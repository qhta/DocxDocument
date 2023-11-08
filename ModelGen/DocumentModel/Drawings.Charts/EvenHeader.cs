namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Even Header.
/// </summary>
public partial class EvenHeader: ModelElement<DXDC.EvenHeader>
{
  public EvenHeader(): base(){ }
  
  public EvenHeader(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EvenHeader(DXDC.EvenHeader openXmlElement): base(openXmlElement) { }
  
}
