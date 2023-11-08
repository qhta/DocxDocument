namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on the left side of the page around the specified paragraph. This shall not change based on the paragraph direction.
/// </summary>
public partial class LeftBorder: ModelElement<DXW.LeftBorder>
{
  public LeftBorder(): base(){ }
  
  public LeftBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LeftBorder(DXW.LeftBorder openXmlElement): base(openXmlElement) { }
  
}
