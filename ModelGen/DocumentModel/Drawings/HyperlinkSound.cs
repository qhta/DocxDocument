namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a sound to be played when a hyperlink within the document is activated. This sound is specified from within the parent hyperlink element.
/// </summary>
public partial class HyperlinkSound: ModelElement<DXD.HyperlinkSound>
{
  public HyperlinkSound(): base(){ }
  
  public HyperlinkSound(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkSound(DXD.HyperlinkSound openXmlElement): base(openXmlElement) { }
  
}
