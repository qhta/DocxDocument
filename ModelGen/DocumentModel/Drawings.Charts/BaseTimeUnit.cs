namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BaseTimeUnit Class.
/// </summary>
public partial class BaseTimeUnit: ModelElement<DXDC.BaseTimeUnit>
{
  public BaseTimeUnit(): base(){ }
  
  public BaseTimeUnit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BaseTimeUnit(DXDC.BaseTimeUnit openXmlElement): base(openXmlElement) { }
  
}
