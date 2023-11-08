namespace DocumentModel.Drawings.Charts;


/// <summary>
///   User Shapes.
/// </summary>
public partial class UserShapes: ModelElement<DXDC.UserShapes>
{
  public UserShapes(): base(){ }
  
  public UserShapes(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UserShapes(DXDC.UserShapes openXmlElement): base(openXmlElement) { }
  
}
