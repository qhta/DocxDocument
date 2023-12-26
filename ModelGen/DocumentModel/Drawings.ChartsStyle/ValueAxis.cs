namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ValueAxis Class.
/// </summary>
public partial class ValueAxis: ModelElement<DXO13DCS.ValueAxis>
{
  public ValueAxis(): base(){ }
  
  public ValueAxis(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueAxis(DXO13DCS.ValueAxis openXmlElement): base(openXmlElement) { }
  
}
