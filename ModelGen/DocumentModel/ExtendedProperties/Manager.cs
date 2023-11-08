namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Name of Manager.
/// </summary>
public partial class Manager: ModelElement<DXEP.Manager>
{
  public Manager(): base(){ }
  
  public Manager(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Manager(DXEP.Manager openXmlElement): base(openXmlElement) { }
  
}
