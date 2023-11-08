namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Application Version.
/// </summary>
public partial class ApplicationVersion: ModelElement<DXEP.ApplicationVersion>
{
  public ApplicationVersion(): base(){ }
  
  public ApplicationVersion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ApplicationVersion(DXEP.ApplicationVersion openXmlElement): base(openXmlElement) { }
  
}
