namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run shall not report any errors when the document is scanned for spelling and grammar.
/// </summary>
public partial class NoProof: ModelElement<DXW.NoProof>
{
  public NoProof(): base(){ }
  
  public NoProof(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoProof(DXW.NoProof openXmlElement): base(openXmlElement) { }
  
}
