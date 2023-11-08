namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Shared Document.
/// </summary>
public partial class SharedDocument: ModelElement<DXEP.SharedDocument>
{
  public SharedDocument(): base(){ }
  
  public SharedDocument(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SharedDocument(DXEP.SharedDocument openXmlElement): base(openXmlElement) { }
  
}
