namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Connection List.
/// </summary>
public partial class ConnectionList: ModelElement<DXDDD.ConnectionList>
{
  public ConnectionList(): base(){ }
  
  public ConnectionList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConnectionList(DXDDD.ConnectionList openXmlElement): base(openXmlElement) { }
  
}
