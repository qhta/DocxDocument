namespace DocumentModel.Wordprocessing;

/// <summary>
/// Write Protection.
/// </summary>
public interface IWriteProtection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Recommend Write Protection in User Interface
  /// </summary>
  public System.Boolean? Recommended { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public DocumentModel.Wordprocessing.CryptProviderKind? CryptographicProviderType { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public DocumentModel.Wordprocessing.CryptAlgorithmClassKind? CryptographicAlgorithmClass { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public DocumentModel.Wordprocessing.CryptAlgorithmKind? CryptographicAlgorithmType { get ; set; }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public System.Int32? CryptographicAlgorithmSid { get ; set; }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public System.UInt32? CryptographicSpinCount { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public System.String? CryptographicProvider { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public DocumentModel.IHexBinaryValue? AlgorithmIdExtensibility { get ; set; }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public System.String? AlgorithmIdExtensibilitySource { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public DocumentModel.IHexBinaryValue? CryptographicProviderTypeExtensibility { get ; set; }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public System.String? CryptographicProviderTypeExtSource { get ; set; }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public DocumentModel.IBase64BinaryValue? Hash { get ; set; }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public DocumentModel.IBase64BinaryValue? Salt { get ; set; }
  
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
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? SpinCount { get ; set; }
  
}
