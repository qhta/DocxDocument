namespace DocumentModel.Wordprocessing;


/// <summary>
///   Font Table Root Element.
/// </summary>
public partial class Fonts: ModelElement<DXW.Fonts>
{
  public Fonts(): base(){ }
  
  public Fonts(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Fonts(DXW.Fonts openXmlElement): base(openXmlElement) { }
  
}
