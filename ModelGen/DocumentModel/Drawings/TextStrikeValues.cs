namespace DocumentModel.Drawings;


/// <summary>
///   Text Strike Type
/// </summary>
public partial class TextStrikeValues: ModelElement<DXD.TextStrikeValues>
{
  public TextStrikeValues(): base(){ }
  
  public TextStrikeValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextStrikeValues(DXD.TextStrikeValues openXmlElement): base(openXmlElement) { }
  
}
