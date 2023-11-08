namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Minimum.
/// </summary>
public partial class MinAxisValue: ModelElement<DXDC.MinAxisValue>
{
  public MinAxisValue(): base(){ }
  
  public MinAxisValue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinAxisValue(DXDC.MinAxisValue openXmlElement): base(openXmlElement) { }
  
}
