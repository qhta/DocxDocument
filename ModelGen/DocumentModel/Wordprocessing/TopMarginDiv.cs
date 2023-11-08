namespace DocumentModel.Wordprocessing;


/// <summary>
///   Top Margin for HTML div.
/// </summary>
public partial class TopMarginDiv: ModelElement<DXW.TopMarginDiv>
{
  public TopMarginDiv(): base(){ }
  
  public TopMarginDiv(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TopMarginDiv(DXW.TopMarginDiv openXmlElement): base(openXmlElement) { }
  
}
