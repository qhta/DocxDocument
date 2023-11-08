namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the text in this paragraph shall be allowed to extend one character beyond the extents applied by any indents/margins when the character that extends past those extents is a punctuation character.
/// </summary>
public partial class OverflowPunctuation: ModelElement<DXW.OverflowPunctuation>
{
  public OverflowPunctuation(): base(){ }
  
  public OverflowPunctuation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OverflowPunctuation(DXW.OverflowPunctuation openXmlElement): base(openXmlElement) { }
  
}
