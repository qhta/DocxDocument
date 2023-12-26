namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the PlotArea3D Class.
/// </summary>
public partial class PlotArea3D: ModelElement<DXO13DCS.PlotArea3D>
{
  public PlotArea3D(): base(){ }
  
  public PlotArea3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotArea3D(DXO13DCS.PlotArea3D openXmlElement): base(openXmlElement) { }
  
}
