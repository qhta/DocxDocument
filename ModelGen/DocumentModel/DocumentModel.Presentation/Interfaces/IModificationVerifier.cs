namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ModificationVerifier Class.
/// </summary>
public interface IModificationVerifier // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public DocumentModel.Presentation.CryptProviderValues? CryptographicProviderType { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public DocumentModel.Presentation.CryptAlgorithmClassValues? CryptographicAlgorithmClass { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public DocumentModel.Presentation.CryptAlgorithmValues? CryptographicAlgorithmType { get ; set; }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public uint? CryptographicAlgorithmSid { get ; set; }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public uint? SpinCount { get ; set; }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public IBase64BinaryValue? SaltData { get ; set; }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public string? HashData { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public string? CryptographicProvider { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public uint? ExtendedCryptographicAlgorithm { get ; set; }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public string? ExtendedCryptographicAlgorithmSource { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public uint? CryptographicProviderTypeExtensibility { get ; set; }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public string? CryptographicProviderTypeExtensibilitySource { get ; set; }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public string? AlgorithmName { get ; set; }
  
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
  public uint? SpinValue { get ; set; }
  
}
