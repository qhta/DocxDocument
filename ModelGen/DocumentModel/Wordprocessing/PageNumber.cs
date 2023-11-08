namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a page number block at the current location in the run content. A page number block is a non-editable region of text which shall display the current page using ascending decimal numbers.
/// </summary>
public partial class PageNumber: ModelElement<DXW.PageNumber>
{
  public PageNumber(): base(){ }
  
  public PageNumber(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageNumber(DXW.PageNumber openXmlElement): base(openXmlElement) { }
  
}
