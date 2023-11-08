namespace DocumentModel.Wordprocessing;


/// <summary>
///   Embed Common System Fonts.
/// </summary>
public partial class EmbedSystemFonts: ModelElement<DXW.EmbedSystemFonts>
{
  public EmbedSystemFonts(): base(){ }
  
  public EmbedSystemFonts(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbedSystemFonts(DXW.EmbedSystemFonts openXmlElement): base(openXmlElement) { }
  
}
