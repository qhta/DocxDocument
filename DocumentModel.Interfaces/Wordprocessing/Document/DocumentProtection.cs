namespace DocumentModel.Wordprocessing;
/// <summary>
///   Document Editing Restrictions.
/// </summary>
public interface DocumentProtection: IModelElement
{
  /// <summary>
  ///   Document Editing Restrictions
  /// </summary>
  public DocumentProtectionKind? Edit { get; set; }
  /// <summary>
  ///   Only Allow Formatting With Unlocked Styles
  /// </summary>
  public bool? Formatting { get; set; }
  /// <summary>
  ///   Enforce Document Protection Settings
  /// </summary>
  public bool? Enforcement { get; set; }
  /// <summary>
  ///   Cryptographic Provider Type
  /// </summary>
  public CryptProviderKind? CryptographicProviderType { get; set; }
  /// <summary>
  ///   Cryptographic Algorithm Class
  /// </summary>
  public CryptAlgorithmClassKind? CryptographicAlgorithmClass { get; set; }
  /// <summary>
  ///   Cryptographic Algorithm Type
  /// </summary>
  public CryptAlgorithmKind? CryptographicAlgorithmType { get; set; }
  /// <summary>
  ///   Cryptographic Hashing Algorithm
  /// </summary>
  public Int32? CryptographicAlgorithmSid { get; set; }
  /// <summary>
  ///   Iterations to Run Hashing Algorithm
  /// </summary>
  public UInt32? CryptographicSpinCount { get; set; }
  /// <summary>
  ///   Cryptographic Provider
  /// </summary>
  public string? CryptographicProvider { get; set; }
  /// <summary>
  ///   Cryptographic Algorithm Extensibility
  /// </summary>
  public HexInt? AlgorithmIdExtensibility { get; set; }
  /// <summary>
  ///   Algorithm Extensibility Source
  /// </summary>
  public string? AlgorithmIdExtensibilitySource { get; set; }
  /// <summary>
  ///   Cryptographic Provider Type Extensibility
  /// </summary>
  public HexInt? CryptographicProviderTypeExtensibility { get; set; }
  /// <summary>
  ///   Provider Type Extensibility Source
  /// </summary>
  public string? CryptographicProviderTypeExtSource { get; set; }
  /// <summary>
  ///   Password Hash
  /// </summary>
  public Base64Binary? Hash { get; set; }
  /// <summary>
  ///   Salt for Password Verifier
  /// </summary>
  public Base64Binary? Salt { get; set; }
  /// <summary>
  ///   algorithmName
  /// </summary>
  public string? AlgorithmName { get; set; }
  /// <summary>
  ///   hashValue
  /// </summary>
  public Base64Binary? HashValue { get; set; }
  /// <summary>
  ///   saltValue
  /// </summary>
  public Base64Binary? SaltValue { get; set; }
  /// <summary>
  ///   spinCount
  /// </summary>
  public Int32? SpinCount { get; set; }
}