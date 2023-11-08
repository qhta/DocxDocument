namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Hyphenate Words in ALL CAPITAL LETTERS.
/// </summary>
public partial class DoNotHyphenateCaps: ModelElement<DXW.DoNotHyphenateCaps>
{
  public DoNotHyphenateCaps(): base(){ }
  
  public DoNotHyphenateCaps(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotHyphenateCaps(DXW.DoNotHyphenateCaps openXmlElement): base(openXmlElement) { }
  
}
