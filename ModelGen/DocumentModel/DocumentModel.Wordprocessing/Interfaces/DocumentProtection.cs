namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Editing Restrictions.
/// </summary>
public interface DocumentProtection
{
  /// <summary>
  /// Document Editing Restrictions
  /// </summary>
  public DocumentProtectionKind? Edit { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public CryptProviderKind? CryptographicProviderType { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public CryptAlgorithmClassKind? CryptographicAlgorithmClass { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public CryptAlgorithmKind? CryptographicAlgorithmType { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public String? AlgorithmIdExtensibility { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public String? CryptographicProviderTypeExtensibility { get ; set; }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public String? Hash { get ; set; }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public String? Salt { get ; set; }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public String? HashValue { get ; set; }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public String? SaltValue { get ; set; }
  
}
