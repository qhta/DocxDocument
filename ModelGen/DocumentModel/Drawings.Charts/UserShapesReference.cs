namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UserShapesReference Class.
/// </summary>
public partial class UserShapesReference: ModelElement<DXDC.UserShapesReference>
{
  public UserShapesReference(): base(){ }
  
  public UserShapesReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UserShapesReference(DXDC.UserShapesReference openXmlElement): base(openXmlElement) { }
  
}
