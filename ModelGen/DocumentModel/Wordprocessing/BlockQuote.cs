namespace DocumentModel.Wordprocessing;


/// <summary>
///   Data for HTML blockquote Element.
/// </summary>
public partial class BlockQuote: ModelElement<DXW.BlockQuote>
{
  public BlockQuote(): base(){ }
  
  public BlockQuote(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BlockQuote(DXW.BlockQuote openXmlElement): base(openXmlElement) { }
  
}
