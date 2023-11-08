namespace DocumentModel.Wordprocessing;


/// <summary>
///   Left Margin for HTML div.
/// </summary>
public partial class LeftMarginDiv: ModelElement<DXW.LeftMarginDiv>
{
  public LeftMarginDiv(): base(){ }
  
  public LeftMarginDiv(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LeftMarginDiv(DXW.LeftMarginDiv openXmlElement): base(openXmlElement) { }
  
}
