namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the style which shall automatically be applied to a new paragraph created following a paragraph with the parent paragraph style applied.
/// </summary>
public partial class NextParagraphStyle: ModelElement<DXW.NextParagraphStyle>
{
  public NextParagraphStyle(): base(){ }
  
  public NextParagraphStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NextParagraphStyle(DXW.NextParagraphStyle openXmlElement): base(openXmlElement) { }
  
}
