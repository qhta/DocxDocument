namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the MarkerStyle enumeration.
/// </summary>
public partial class MarkerStyle: ModelElement<DXO13DCS.MarkerStyle>
{
  public MarkerStyle(): base(){ }
  
  public MarkerStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkerStyle(DXO13DCS.MarkerStyle openXmlElement): base(openXmlElement) { }
  
}
