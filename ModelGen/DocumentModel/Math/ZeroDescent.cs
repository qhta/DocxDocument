namespace DocumentModel.Math;


/// <summary>
///   Phantom Zero Descent.
/// </summary>
public partial class ZeroDescent: ModelElement<DXM.ZeroDescent>
{
  public ZeroDescent(): base(){ }
  
  public ZeroDescent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ZeroDescent(DXM.ZeroDescent openXmlElement): base(openXmlElement) { }
  
}
