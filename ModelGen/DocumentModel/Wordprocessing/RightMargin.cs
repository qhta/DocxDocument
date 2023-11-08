namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on the right side of the page around the specified paragraph. This shall not change based on the paragraph direction.
/// </summary>
public partial class RightMargin: ModelElement<DXW.RightMargin>
{
  public RightMargin(): base(){ }
  
  public RightMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RightMargin(DXW.RightMargin openXmlElement): base(openXmlElement) { }
  
}
