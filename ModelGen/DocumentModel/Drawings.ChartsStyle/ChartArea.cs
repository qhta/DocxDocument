namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ChartArea Class.
/// </summary>
public partial class ChartArea: ModelElement<DXO13DCS.ChartArea>
{
  public ChartArea(): base(){ }
  
  public ChartArea(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartArea(DXO13DCS.ChartArea openXmlElement): base(openXmlElement) { }
  
}
