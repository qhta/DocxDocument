namespace DocumentModel.Wordprocessing;


/// <summary>
///   Carriage Return.
/// </summary>
public partial class CarriageReturn: ModelElement<DXW.CarriageReturn>
{
  public CarriageReturn(): base(){ }
  
  public CarriageReturn(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CarriageReturn(DXW.CarriageReturn openXmlElement): base(openXmlElement) { }
  
}
