namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Chart Object.
/// </summary>
public partial class ChartObject: ModelElement<DXDC.ChartObject>
{
  public ChartObject(): base(){ }
  
  public ChartObject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartObject(DXDC.ChartObject openXmlElement): base(openXmlElement) { }
  
}
