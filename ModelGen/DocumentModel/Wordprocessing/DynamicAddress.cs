namespace DocumentModel.Wordprocessing;


/// <summary>
///   Use Country/Region-Based Address Field Ordering.
/// </summary>
public partial class DynamicAddress: ModelElement<DXW.DynamicAddress>
{
  public DynamicAddress(): base(){ }
  
  public DynamicAddress(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DynamicAddress(DXW.DynamicAddress openXmlElement): base(openXmlElement) { }
  
}
