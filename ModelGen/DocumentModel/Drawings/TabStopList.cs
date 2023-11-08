namespace DocumentModel.Drawings;


/// <summary>
///   Tab List.
/// </summary>
public partial class TabStopList: ModelElement<DXD.TabStopList>
{
  public TabStopList(): base(){ }
  
  public TabStopList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TabStopList(DXD.TabStopList openXmlElement): base(openXmlElement) { }
  
}
