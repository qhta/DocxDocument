namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Rule List.
/// </summary>
public partial class RuleList: ModelElement<DXDDD.RuleList>
{
  public RuleList(): base(){ }
  
  public RuleList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RuleList(DXDDD.RuleList openXmlElement): base(openXmlElement) { }
  
}
