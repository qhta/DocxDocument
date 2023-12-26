namespace DocumentModel.Drawings;


/// <summary>
///   Default Paragraph Style.
/// </summary>
public partial class DefaultParagraphProperties: ModelElement<DXD.DefaultParagraphProperties>
{
  public DefaultParagraphProperties(): base(){ }
  
  public DefaultParagraphProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DefaultParagraphProperties(DXD.DefaultParagraphProperties openXmlElement): base(openXmlElement) { }
  
}
