namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the EmbedItalicFont Class.
/// </summary>
public partial class EmbedItalicFont: ModelElement<DXW.EmbedItalicFont>
{
  public EmbedItalicFont(): base(){ }
  
  public EmbedItalicFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbedItalicFont(DXW.EmbedItalicFont openXmlElement): base(openXmlElement) { }
  
}
