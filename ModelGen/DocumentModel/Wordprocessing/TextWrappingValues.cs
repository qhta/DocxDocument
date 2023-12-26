namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextWrappingValues enumeration.
/// </summary>
public partial class TextWrappingValues: ModelElement<DXW.TextWrappingValues>
{
  public TextWrappingValues(): base(){ }
  
  public TextWrappingValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextWrappingValues(DXW.TextWrappingValues openXmlElement): base(openXmlElement) { }
  
}
