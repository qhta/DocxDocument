namespace DocumentModel.Drawings;


/// <summary>
///   Text Wrapping Types
/// </summary>
public partial class TextWrappingValues: ModelElement<DXD.TextWrappingValues>
{
  public TextWrappingValues(): base(){ }
  
  public TextWrappingValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextWrappingValues(DXD.TextWrappingValues openXmlElement): base(openXmlElement) { }
  
}
