namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TrendlineStyle Class.
/// </summary>
public partial class TrendlineStyle: ModelElement<DXO13DCS.TrendlineStyle>
{
  public TrendlineStyle(): base(){ }
  
  public TrendlineStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TrendlineStyle(DXO13DCS.TrendlineStyle openXmlElement): base(openXmlElement) { }
  
}
