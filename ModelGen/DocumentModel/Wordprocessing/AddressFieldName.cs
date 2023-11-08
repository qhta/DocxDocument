namespace DocumentModel.Wordprocessing;


/// <summary>
///   Column Containing E-mail Address.
/// </summary>
public partial class AddressFieldName: ModelElement<DXW.AddressFieldName>
{
  public AddressFieldName(): base(){ }
  
  public AddressFieldName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AddressFieldName(DXW.AddressFieldName openXmlElement): base(openXmlElement) { }
  
}
