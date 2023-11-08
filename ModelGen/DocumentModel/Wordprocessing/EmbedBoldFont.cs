namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the EmbedBoldFont Class.
/// </summary>
public partial class EmbedBoldFont: ModelElement<DXW.EmbedBoldFont>
{
  public EmbedBoldFont(): base(){ }
  
  public EmbedBoldFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbedBoldFont(DXW.EmbedBoldFont openXmlElement): base(openXmlElement) { }
  
}
