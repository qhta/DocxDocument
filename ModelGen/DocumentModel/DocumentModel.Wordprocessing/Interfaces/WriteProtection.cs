namespace DocumentModel.Wordprocessing;

/// <summary>
/// Write Protection.
/// </summary>
public partial interface WriteProtection
{
  /// <summary>
  /// Recommend Write Protection in User Interface
  /// </summary>
  public Boolean? Recommended { get; set; }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public DocumentModel.Wordprocessing.CryptProviderKind? CryptographicProviderType { get; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public DocumentModel.Wordprocessing.CryptAlgorithmClassKind? CryptographicAlgorithmClass { get; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public DocumentModel.Wordprocessing.CryptAlgorithmKind? CryptographicAlgorithmType { get; set; }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public Int32? CryptographicAlgorithmSid { get; set; }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public UInt32? CryptographicSpinCount { get; set; }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public String? CryptographicProvider { get; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public DocumentModel.HexBinary? AlgorithmIdExtensibility { get; set; }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public String? AlgorithmIdExtensibilitySource { get; set; }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public DocumentModel.HexBinary? CryptographicProviderTypeExtensibility { get; set; }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public String? CryptographicProviderTypeExtSource { get; set; }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public DocumentModel.Base64Binary? Hash { get; set; }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public DocumentModel.Base64Binary? Salt { get; set; }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AlgorithmName { get; set; }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Base64Binary? HashValue { get; set; }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Base64Binary? SaltValue { get; set; }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SpinCount { get; set; }
  
}
