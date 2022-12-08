namespace DocumentModel.Wordprocessing;

/// <summary>
/// Write Protection.
/// </summary>
public class WriteProtectionImpl: ModelElementImpl, WriteProtection
{
  public DocumentFormat.OpenXml.Wordprocessing.WriteProtection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.WriteProtection?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Recommend Write Protection in User Interface
  /// </summary>
  public Boolean? Recommended
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public CryptProviderKind? CryptographicProviderType
  {
    get => (CryptProviderKind?)OpenXmlElement?.CryptographicProviderType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicProviderType = (DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public CryptAlgorithmClassKind? CryptographicAlgorithmClass
  {
    get => (CryptAlgorithmClassKind?)OpenXmlElement?.CryptographicAlgorithmClass?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicAlgorithmClass = (DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public CryptAlgorithmKind? CryptographicAlgorithmType
  {
    get => (CryptAlgorithmKind?)OpenXmlElement?.CryptographicAlgorithmType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicAlgorithmType = (DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public Int32? CryptographicAlgorithmSid
  {
    get;
    set;
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public UInt32? CryptographicSpinCount
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public String? CryptographicProvider
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public DocumentModel.HexBinaryValue? AlgorithmIdExtensibility
  {
    get;
    set;
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public String? AlgorithmIdExtensibilitySource
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public DocumentModel.HexBinaryValue? CryptographicProviderTypeExtensibility
  {
    get;
    set;
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public String? CryptographicProviderTypeExtSource
  {
    get;
    set;
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public DocumentModel.Base64BinaryValue? Hash
  {
    get;
    set;
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public DocumentModel.Base64BinaryValue? Salt
  {
    get;
    set;
  }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AlgorithmName
  {
    get;
    set;
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Base64BinaryValue? HashValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Base64BinaryValue? SaltValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SpinCount
  {
    get;
    set;
  }
  
}
