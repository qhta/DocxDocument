namespace DocumentModel.Wordprocessing;


/// <summary>
///   Special Endnote List.
/// </summary>
public partial class EndnoteSpecialReference: ModelElement<DXW.EndnoteSpecialReference>
{
  public EndnoteSpecialReference(): base(){ }
  
  public EndnoteSpecialReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EndnoteSpecialReference(DXW.EndnoteSpecialReference openXmlElement): base(openXmlElement) { }
  
}
