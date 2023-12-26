namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Background Formatting.
/// </summary>
public partial class Background: ModelElement<DXDDD.Background>
{
  public Background(): base(){ }
  
  public Background(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Background(DXDDD.Background openXmlElement): base(openXmlElement) { }
  
}
