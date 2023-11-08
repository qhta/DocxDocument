namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that lines joined together have a round join.
/// </summary>
public partial class Round: ModelElement<DXD.Round>
{
  public Round(): base(){ }
  
  public Round(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Round(DXD.Round openXmlElement): base(openXmlElement) { }
  
}
