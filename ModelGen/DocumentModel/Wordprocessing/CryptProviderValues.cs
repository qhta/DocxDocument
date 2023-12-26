namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CryptProviderValues enumeration.
/// </summary>
public partial class CryptProviderValues: ModelElement<DXW.CryptProviderValues>
{
  public CryptProviderValues(): base(){ }
  
  public CryptProviderValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CryptProviderValues(DXW.CryptProviderValues openXmlElement): base(openXmlElement) { }
  
}
