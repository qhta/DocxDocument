namespace DocumentModel.Drawings;


/// <summary>
///   Text Underline Types
/// </summary>
public partial class TextUnderlineValues: ModelElement<DXD.TextUnderlineValues>
{
  public TextUnderlineValues(): base(){ }
  
  public TextUnderlineValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextUnderlineValues(DXD.TextUnderlineValues openXmlElement): base(openXmlElement) { }
  
}
