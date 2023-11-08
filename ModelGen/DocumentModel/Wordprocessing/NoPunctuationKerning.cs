namespace DocumentModel.Wordprocessing;


/// <summary>
///   Never Kern Punctuation Characters.
/// </summary>
public partial class NoPunctuationKerning: ModelElement<DXW.NoPunctuationKerning>
{
  public NoPunctuationKerning(): base(){ }
  
  public NoPunctuationKerning(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoPunctuationKerning(DXW.NoPunctuationKerning openXmlElement): base(openXmlElement) { }
  
}
