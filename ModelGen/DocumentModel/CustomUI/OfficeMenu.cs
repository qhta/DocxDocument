namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the OfficeMenu Class.
/// </summary>
public partial class OfficeMenu: ModelElement<DXOCUI.OfficeMenu>
{
  public OfficeMenu(): base(){ }
  
  public OfficeMenu(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OfficeMenu(DXOCUI.OfficeMenu openXmlElement): base(openXmlElement) { }
  
}
