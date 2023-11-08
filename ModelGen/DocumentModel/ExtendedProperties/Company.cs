namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Name of Company.
/// </summary>
public partial class Company: ModelElement<DXEP.Company>
{
  public Company(): base(){ }
  
  public Company(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Company(DXEP.Company openXmlElement): base(openXmlElement) { }
  
}
