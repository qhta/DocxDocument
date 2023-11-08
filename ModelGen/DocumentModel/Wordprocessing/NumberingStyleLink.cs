namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Style Reference.
/// </summary>
public partial class NumberingStyleLink: ModelElement<DXW.NumberingStyleLink>
{
  public NumberingStyleLink(): base(){ }
  
  public NumberingStyleLink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingStyleLink(DXW.NumberingStyleLink openXmlElement): base(openXmlElement) { }
  
}
