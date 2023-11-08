namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Word Count.
/// </summary>
public partial class Words: ModelElement<DXEP.Words>
{
  public Words(): base(){ }
  
  public Words(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Words(DXEP.Words openXmlElement): base(openXmlElement) { }
  
}
