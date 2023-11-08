namespace DocumentModel.Wordprocessing;


/// <summary>
///   Top and Bottom Margin for Frame.
/// </summary>
public partial class MarginHeight: ModelElement<DXW.MarginHeight>
{
  public MarginHeight(): base(){ }
  
  public MarginHeight(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarginHeight(DXW.MarginHeight openXmlElement): base(openXmlElement) { }
  
}
