namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the style ID of the paragraph style which shall be used to format the contents of this paragraph.
/// </summary>
public partial class ParagraphStyleIdInLevel: ModelElement<DXW.ParagraphStyleIdInLevel>
{
  public ParagraphStyleIdInLevel(): base(){ }
  
  public ParagraphStyleIdInLevel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphStyleIdInLevel(DXW.ParagraphStyleIdInLevel openXmlElement): base(openXmlElement) { }
  
}
