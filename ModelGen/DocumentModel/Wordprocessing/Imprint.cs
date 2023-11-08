namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run should be displayed as if imprinted, which makes text appear to be imprinted or pressed into page (also referred to as 'engrave').
/// </summary>
public partial class Imprint: ModelElement<DXW.Imprint>
{
  public Imprint(): base(){ }
  
  public Imprint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Imprint(DXW.Imprint openXmlElement): base(openXmlElement) { }
  
}
