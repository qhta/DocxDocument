namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the contents of this run shall be hidden from display at display time in a document.
/// </summary>
public partial class Vanish: ModelElement<DXW.Vanish>
{
  public Vanish(): base(){ }
  
  public Vanish(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Vanish(DXW.Vanish openXmlElement): base(openXmlElement) { }
  
}
