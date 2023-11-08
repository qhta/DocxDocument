namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Application Name.
/// </summary>
public partial class Application: ModelElement<DXEP.Application>
{
  public Application(): base(){ }
  
  public Application(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Application(DXEP.Application openXmlElement): base(openXmlElement) { }
  
}
