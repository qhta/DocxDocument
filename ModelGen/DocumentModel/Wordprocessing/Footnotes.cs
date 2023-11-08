namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document Footnotes.
/// </summary>
public partial class Footnotes: ModelElement<DXW.Footnotes>
{
  public Footnotes(): base(){ }
  
  public Footnotes(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Footnotes(DXW.Footnotes openXmlElement): base(openXmlElement) { }
  
}
