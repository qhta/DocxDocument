namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the Wall Class.
/// </summary>
public partial class Wall: ModelElement<DXO13DCS.Wall>
{
  public Wall(): base(){ }
  
  public Wall(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Wall(DXO13DCS.Wall openXmlElement): base(openXmlElement) { }
  
}
