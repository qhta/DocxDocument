namespace DocumentModel.Wordprocessing;


/// <summary>
///   Right Margin for HTML div.
/// </summary>
public partial class RightMarginDiv: ModelElement<DXW.RightMarginDiv>
{
  public RightMarginDiv(): base(){ }
  
  public RightMarginDiv(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RightMarginDiv(DXW.RightMarginDiv openXmlElement): base(openXmlElement) { }
  
}
