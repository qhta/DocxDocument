namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the ending connection that should be made by the corresponding connector shape. This connects the end tail of the connector to the final destination shape.
/// </summary>
public partial class EndConnection: ModelElement<DXD.EndConnection>
{
  public EndConnection(): base(){ }
  
  public EndConnection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EndConnection(DXD.EndConnection openXmlElement): base(openXmlElement) { }
  
}
