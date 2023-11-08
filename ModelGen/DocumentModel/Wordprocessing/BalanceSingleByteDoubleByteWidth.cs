namespace DocumentModel.Wordprocessing;


/// <summary>
///   Balance Single Byte and Double Byte Characters.
/// </summary>
public partial class BalanceSingleByteDoubleByteWidth: ModelElement<DXW.BalanceSingleByteDoubleByteWidth>
{
  public BalanceSingleByteDoubleByteWidth(): base(){ }
  
  public BalanceSingleByteDoubleByteWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BalanceSingleByteDoubleByteWidth(DXW.BalanceSingleByteDoubleByteWidth openXmlElement): base(openXmlElement) { }
  
}
