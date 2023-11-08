namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether punctuation shall be compressed when it appears as the first character in a line, allowing subsequent characters on the line to be move in accordingly.
/// </summary>
public partial class TopLinePunctuation: ModelElement<DXW.TopLinePunctuation>
{
  public TopLinePunctuation(): base(){ }
  
  public TopLinePunctuation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TopLinePunctuation(DXW.TopLinePunctuation openXmlElement): base(openXmlElement) { }
  
}
