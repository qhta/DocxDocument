namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether a consumer shall break text which exceeds the text extents of a line by breaking the word across two lines (breaking on the character level) or by moving the word to the following line (breaking
/// </summary>
public partial class WordWrap: ModelElement<DXW.WordWrap>
{
  public WordWrap(): base(){ }
  
  public WordWrap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WordWrap(DXW.WordWrap openXmlElement): base(openXmlElement) { }
  
}
