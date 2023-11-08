namespace DocumentModel.Wordprocessing;


/// <summary>
///   Endnote Reference.
/// </summary>
public partial class EndnoteReference: ModelElement<DXW.EndnoteReference>
{
  public EndnoteReference(): base(){ }
  
  public EndnoteReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EndnoteReference(DXW.EndnoteReference openXmlElement): base(openXmlElement) { }
  
}
