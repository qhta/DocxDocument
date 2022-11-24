namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ModificationVerifier Class.
/// </summary>
public interface IModificationVerifier // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public CryptProviderValues? CryptographicProviderType { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public CryptAlgorithmClassValues? CryptographicAlgorithmClass { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public CryptAlgorithmValues? CryptographicAlgorithmType { get ; set; }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public UInt32? CryptographicAlgorithmSid { get ; set; }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public UInt32? SpinCount { get ; set; }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public IBase64BinaryValue? SaltData { get ; set; }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public String? HashData { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public String? CryptographicProvider { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public UInt32? ExtendedCryptographicAlgorithm { get ; set; }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public String? ExtendedCryptographicAlgorithmSource { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public UInt32? CryptographicProviderTypeExtensibility { get ; set; }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public String? CryptographicProviderTypeExtensibilitySource { get ; set; }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AlgorithmName { get ; set; }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// spinValue, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? SpinValue { get ; set; }
  
}
