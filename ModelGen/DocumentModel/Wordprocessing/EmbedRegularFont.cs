namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the EmbedRegularFont Class.
/// </summary>
public partial class EmbedRegularFont: ModelElement<DXW.EmbedRegularFont>
{
  public EmbedRegularFont(): base(){ }
  
  public EmbedRegularFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbedRegularFont(DXW.EmbedRegularFont openXmlElement): base(openXmlElement) { }
  
}
