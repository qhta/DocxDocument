namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Show Value.
/// </summary>
public partial class ShowValue: ModelElement<DXDC.ShowValue>
{
  public ShowValue(): base(){ }
  
  public ShowValue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShowValue(DXDC.ShowValue openXmlElement): base(openXmlElement) { }
  
}
