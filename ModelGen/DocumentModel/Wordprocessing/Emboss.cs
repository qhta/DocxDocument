namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run should be displayed as if embossed, which makes text appear as if it is raised off the page in relief.
/// </summary>
public partial class Emboss: ModelElement<DXW.Emboss>
{
  public Emboss(): base(){ }
  
  public Emboss(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Emboss(DXW.Emboss openXmlElement): base(openXmlElement) { }
  
}
