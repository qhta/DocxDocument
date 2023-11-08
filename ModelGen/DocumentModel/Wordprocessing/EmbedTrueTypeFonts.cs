namespace DocumentModel.Wordprocessing;


/// <summary>
///   Embed TrueType Fonts.
/// </summary>
public partial class EmbedTrueTypeFonts: ModelElement<DXW.EmbedTrueTypeFonts>
{
  public EmbedTrueTypeFonts(): base(){ }
  
  public EmbedTrueTypeFonts(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbedTrueTypeFonts(DXW.EmbedTrueTypeFonts openXmlElement): base(openXmlElement) { }
  
}
