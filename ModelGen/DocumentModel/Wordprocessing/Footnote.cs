namespace DocumentModel.Wordprocessing;


/// <summary>
///   Footnote Content.
/// </summary>
public partial class Footnote: ModelElement<DXW.Footnote>
{
  public Footnote(): base(){ }
  
  public Footnote(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Footnote(DXW.Footnote openXmlElement): base(openXmlElement) { }
  
}
