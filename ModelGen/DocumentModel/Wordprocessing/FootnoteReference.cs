namespace DocumentModel.Wordprocessing;


/// <summary>
///   Footnote Reference.
/// </summary>
public partial class FootnoteReference: ModelElement<DXW.FootnoteReference>
{
  public FootnoteReference(): base(){ }
  
  public FootnoteReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteReference(DXW.FootnoteReference openXmlElement): base(openXmlElement) { }
  
}
