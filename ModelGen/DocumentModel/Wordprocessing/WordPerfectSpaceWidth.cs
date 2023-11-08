namespace DocumentModel.Wordprocessing;


/// <summary>
///   Space width.
/// </summary>
public partial class WordPerfectSpaceWidth: ModelElement<DXW.WordPerfectSpaceWidth>
{
  public WordPerfectSpaceWidth(): base(){ }
  
  public WordPerfectSpaceWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WordPerfectSpaceWidth(DXW.WordPerfectSpaceWidth openXmlElement): base(openXmlElement) { }
  
}
