namespace DocumentModel.Drawings.Charts;


/// <summary>
///   User Interface.
/// </summary>
public partial class UserInterface: ModelElement<DXDC.UserInterface>
{
  public UserInterface(): base(){ }
  
  public UserInterface(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UserInterface(DXDC.UserInterface openXmlElement): base(openXmlElement) { }
  
}
