namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Custom Display Unit.
/// </summary>
public partial class CustomDisplayUnit: ModelElement<DXDC.CustomDisplayUnit>
{
  public CustomDisplayUnit(): base(){ }
  
  public CustomDisplayUnit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomDisplayUnit(DXDC.CustomDisplayUnit openXmlElement): base(openXmlElement) { }
  
}
