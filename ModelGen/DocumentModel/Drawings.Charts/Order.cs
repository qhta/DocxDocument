namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Order.
/// </summary>
public partial class Order: ModelElement<DXDC.Order>
{
  public Order(): base(){ }
  
  public Order(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Order(DXDC.Order openXmlElement): base(openXmlElement) { }
  
}
