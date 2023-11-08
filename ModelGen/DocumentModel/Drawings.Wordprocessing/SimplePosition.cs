namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Simple Positioning Coordinates.
/// </summary>
public partial class SimplePosition: ModelElement<DXDW.SimplePosition>
{
  public SimplePosition(): base(){ }
  
  public SimplePosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SimplePosition(DXDW.SimplePosition openXmlElement): base(openXmlElement) { }
  
}
