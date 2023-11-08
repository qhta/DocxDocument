namespace DocumentModel.Wordprocessing;


/// <summary>
///   Left and Right Margin for Frame.
/// </summary>
public partial class MarginWidth: ModelElement<DXW.MarginWidth>
{
  public MarginWidth(): base(){ }
  
  public MarginWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarginWidth(DXW.MarginWidth openXmlElement): base(openXmlElement) { }
  
}
