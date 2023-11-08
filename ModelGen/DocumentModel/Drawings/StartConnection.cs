namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the starting connection that should be made by the corresponding connector shape. This connects the head of the connector to the first shape.
/// </summary>
public partial class StartConnection: ModelElement<DXD.StartConnection>
{
  public StartConnection(): base(){ }
  
  public StartConnection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StartConnection(DXD.StartConnection openXmlElement): base(openXmlElement) { }
  
}
