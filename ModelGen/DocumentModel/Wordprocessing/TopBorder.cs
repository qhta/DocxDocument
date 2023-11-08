namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presentation and display of the page border displayed at the top of each page in this section.
/// </summary>
public partial class TopBorder: ModelElement<DXW.TopBorder>
{
  public TopBorder(): base(){ }
  
  public TopBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TopBorder(DXW.TopBorder openXmlElement): base(openXmlElement) { }
  
}
