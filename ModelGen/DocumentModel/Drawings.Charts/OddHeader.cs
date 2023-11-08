namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Odd Header.
/// </summary>
public partial class OddHeader: ModelElement<DXDC.OddHeader>
{
  public OddHeader(): base(){ }
  
  public OddHeader(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OddHeader(DXDC.OddHeader openXmlElement): base(openXmlElement) { }
  
}
