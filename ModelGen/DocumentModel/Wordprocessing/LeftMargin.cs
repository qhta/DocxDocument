namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on the left side of the page around the specified paragraph. This shall not change based on the paragraph direction.
/// </summary>
public partial class LeftMargin: ModelElement<DXW.LeftMargin>
{
  public LeftMargin(): base(){ }
  
  public LeftMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LeftMargin(DXW.LeftMargin openXmlElement): base(openXmlElement) { }
  
}
