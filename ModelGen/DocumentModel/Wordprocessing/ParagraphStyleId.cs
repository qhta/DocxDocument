namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the style ID of the paragraph style which shall be used to format the contents of this paragraph.
/// </summary>
public partial class ParagraphStyleId: ModelElement<DXW.ParagraphStyleId>
{
  public ParagraphStyleId(): base(){ }
  
  public ParagraphStyleId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphStyleId(DXW.ParagraphStyleId openXmlElement): base(openXmlElement) { }
  
}
