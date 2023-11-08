namespace DocumentModel.Math;


/// <summary>
///   Position (Bar).
/// </summary>
public partial class Position: ModelElement<DXM.Position>
{
  public Position(): base(){ }
  
  public Position(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Position(DXM.Position openXmlElement): base(openXmlElement) { }
  
}
