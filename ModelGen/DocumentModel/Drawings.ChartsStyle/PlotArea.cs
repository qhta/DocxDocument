namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the PlotArea Class.
/// </summary>
public partial class PlotArea: ModelElement<DXO13DCS.PlotArea>
{
  public PlotArea(): base(){ }
  
  public PlotArea(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotArea(DXO13DCS.PlotArea openXmlElement): base(openXmlElement) { }
  
}
