namespace DocumentModel.Wordprocessing;


/// <summary>
///   Emulate Word 5.x for the Macintosh Small Caps Formatting.
/// </summary>
public partial class MacWordSmallCaps: ModelElement<DXW.MacWordSmallCaps>
{
  public MacWordSmallCaps(): base(){ }
  
  public MacWordSmallCaps(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MacWordSmallCaps(DXW.MacWordSmallCaps openXmlElement): base(openXmlElement) { }
  
}
