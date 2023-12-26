namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the SeriesLine Class.
/// </summary>
public partial class SeriesLine: ModelElement<DXO13DCS.SeriesLine>
{
  public SeriesLine(): base(){ }
  
  public SeriesLine(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesLine(DXO13DCS.SeriesLine openXmlElement): base(openXmlElement) { }
  
}
