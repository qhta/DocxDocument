namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the glyph representing the end character of current table row shall not be displayed in the current document.
/// </summary>
public partial class Hidden: ModelElement<DXW.Hidden>
{
  public Hidden(): base(){ }
  
  public Hidden(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Hidden(DXW.Hidden openXmlElement): base(openXmlElement) { }
  
}
