namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ModificationVerifier Class.
/// </summary>
public interface IModificationVerifier // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public DocumentModel.Presentation.CryptProviderKind? CryptographicProviderType { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public DocumentModel.Presentation.CryptAlgorithmClassKind? CryptographicAlgorithmClass { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public DocumentModel.Presentation.CryptAlgorithmKind? CryptographicAlgorithmType { get ; set; }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public System.UInt32? CryptographicAlgorithmSid { get ; set; }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public System.UInt32? SpinCount { get ; set; }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public DocumentModel.IBase64BinaryValue? SaltData { get ; set; }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public System.String? HashData { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public System.String? CryptographicProvider { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public System.UInt32? ExtendedCryptographicAlgorithm { get ; set; }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public System.String? ExtendedCryptographicAlgorithmSource { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public System.UInt32? CryptographicProviderTypeExtensibility { get ; set; }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public System.String? CryptographicProviderTypeExtensibilitySource { get ; set; }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? AlgorithmName { get ; set; }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IBase64BinaryValue? HashValue { get ; set; }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IBase64BinaryValue? SaltValue { get ; set; }
  
  /// <summary>
  /// spinValue, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? SpinValue { get ; set; }
  
}
