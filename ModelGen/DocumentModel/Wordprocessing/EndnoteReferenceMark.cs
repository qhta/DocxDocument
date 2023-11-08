namespace DocumentModel.Wordprocessing;


/// <summary>
///   Endnote Reference Mark.
/// </summary>
public partial class EndnoteReferenceMark: ModelElement<DXW.EndnoteReferenceMark>
{
  public EndnoteReferenceMark(): base(){ }
  
  public EndnoteReferenceMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EndnoteReferenceMark(DXW.EndnoteReferenceMark openXmlElement): base(openXmlElement) { }
  
}
