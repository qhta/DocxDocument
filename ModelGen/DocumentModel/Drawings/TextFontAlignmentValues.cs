namespace DocumentModel.Drawings;


/// <summary>
///   Font Alignment Types
/// </summary>
public partial class TextFontAlignmentValues: ModelElement<DXD.TextFontAlignmentValues>
{
  public TextFontAlignmentValues(): base(){ }
  
  public TextFontAlignmentValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextFontAlignmentValues(DXD.TextFontAlignmentValues openXmlElement): base(openXmlElement) { }
  
}
