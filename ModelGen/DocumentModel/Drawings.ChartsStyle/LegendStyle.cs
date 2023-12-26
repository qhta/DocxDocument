namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the LegendStyle Class.
/// </summary>
public partial class LegendStyle: ModelElement<DXO13DCS.LegendStyle>
{
  public LegendStyle(): base(){ }
  
  public LegendStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LegendStyle(DXO13DCS.LegendStyle openXmlElement): base(openXmlElement) { }
  
}
