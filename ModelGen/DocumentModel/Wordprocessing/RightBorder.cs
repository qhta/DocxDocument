namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on the right side of the page around the specified paragraph. This shall not change based on the paragraph direction.
/// </summary>
public partial class RightBorder: ModelElement<DXW.RightBorder>
{
  public RightBorder(): base(){ }
  
  public RightBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RightBorder(DXW.RightBorder openXmlElement): base(openXmlElement) { }
  
}
