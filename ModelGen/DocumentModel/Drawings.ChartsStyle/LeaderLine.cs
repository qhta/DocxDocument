namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the LeaderLine Class.
/// </summary>
public partial class LeaderLine: ModelElement<DXO13DCS.LeaderLine>
{
  public LeaderLine(): base(){ }
  
  public LeaderLine(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LeaderLine(DXO13DCS.LeaderLine openXmlElement): base(openXmlElement) { }
  
}
