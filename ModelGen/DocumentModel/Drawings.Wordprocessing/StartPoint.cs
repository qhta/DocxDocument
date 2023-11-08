namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Wrapping Polygon Start.
/// </summary>
public partial class StartPoint: ModelElement<DXDW.StartPoint>
{
  public StartPoint(): base(){ }
  
  public StartPoint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StartPoint(DXDW.StartPoint openXmlElement): base(openXmlElement) { }
  
}
