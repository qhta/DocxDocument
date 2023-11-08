namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Level.
/// </summary>
public partial class Level: ModelElement<DXDC.Level>
{
  public Level(): base(){ }
  
  public Level(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Level(DXDC.Level openXmlElement): base(openXmlElement) { }
  
}
