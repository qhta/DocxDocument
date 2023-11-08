namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Name of Document Template.
/// </summary>
public partial class Template: ModelElement<DXEP.Template>
{
  public Template(): base(){ }
  
  public Template(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Template(DXEP.Template openXmlElement): base(openXmlElement) { }
  
}
