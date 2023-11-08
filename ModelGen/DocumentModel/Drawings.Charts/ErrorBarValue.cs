namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Error Bar Value.
/// </summary>
public partial class ErrorBarValue: ModelElement<DXDC.ErrorBarValue>
{
  public ErrorBarValue(): base(){ }
  
  public ErrorBarValue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ErrorBarValue(DXDC.ErrorBarValue openXmlElement): base(openXmlElement) { }
  
}
