namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CryptAlgorithmValues enumeration.
/// </summary>
public partial class CryptAlgorithmValues: ModelElement<DXW.CryptAlgorithmValues>
{
  public CryptAlgorithmValues(): base(){ }
  
  public CryptAlgorithmValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CryptAlgorithmValues(DXW.CryptAlgorithmValues openXmlElement): base(openXmlElement) { }
  
}
