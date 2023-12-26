namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TitleStyle Class.
/// </summary>
public partial class TitleStyle: ModelElement<DXO13DCS.TitleStyle>
{
  public TitleStyle(): base(){ }
  
  public TitleStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TitleStyle(DXO13DCS.TitleStyle openXmlElement): base(openXmlElement) { }
  
}
