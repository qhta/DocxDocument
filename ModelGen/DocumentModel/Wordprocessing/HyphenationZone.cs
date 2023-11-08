namespace DocumentModel.Wordprocessing;


/// <summary>
///   Hyphenation Zone.
/// </summary>
public partial class HyphenationZone: ModelElement<DXW.HyphenationZone>
{
  public HyphenationZone(): base(){ }
  
  public HyphenationZone(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyphenationZone(DXW.HyphenationZone openXmlElement): base(openXmlElement) { }
  
}
