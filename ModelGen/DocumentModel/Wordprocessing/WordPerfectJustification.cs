namespace DocumentModel.Wordprocessing;


/// <summary>
///   Emulate WordPerfect 6.x Paragraph Justification.
/// </summary>
public partial class WordPerfectJustification: ModelElement<DXW.WordPerfectJustification>
{
  public WordPerfectJustification(): base(){ }
  
  public WordPerfectJustification(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WordPerfectJustification(DXW.WordPerfectJustification openXmlElement): base(openXmlElement) { }
  
}
