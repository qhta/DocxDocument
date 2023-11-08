namespace DocumentModel.Wordprocessing;


/// <summary>
///   Underline All Trailing Spaces.
/// </summary>
public partial class UnderlineTrailingSpaces: ModelElement<DXW.UnderlineTrailingSpaces>
{
  public UnderlineTrailingSpaces(): base(){ }
  
  public UnderlineTrailingSpaces(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UnderlineTrailingSpaces(DXW.UnderlineTrailingSpaces openXmlElement): base(openXmlElement) { }
  
}
