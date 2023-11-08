namespace DocumentModel.Wordprocessing;


/// <summary>
///   Paragraph Style Applied to Automatically Generated Paragraphs.
/// </summary>
public partial class ClickAndTypeStyle: ModelElement<DXW.ClickAndTypeStyle>
{
  public ClickAndTypeStyle(): base(){ }
  
  public ClickAndTypeStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ClickAndTypeStyle(DXW.ClickAndTypeStyle openXmlElement): base(openXmlElement) { }
  
}
