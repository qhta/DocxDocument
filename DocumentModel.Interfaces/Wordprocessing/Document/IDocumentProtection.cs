namespace DocumentModel.Wordprocessing;
/// <summary>
///   Document Editing Restrictions.
/// </summary>
public interface IDocumentProtection: IModelElement
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
  public IHexInt? AlgorithmIdExtensibility { get; set; }
  /// <summary>
  ///   Algorithm Extensibility Source
  /// </summary>
  public string? AlgorithmIdExtensibilitySource { get; set; }
  /// <summary>
  ///   Cryptographic Provider Type Extensibility
  /// </summary>
  public IHexInt? CryptographicProviderTypeExtensibility { get; set; }
  /// <summary>
  ///   Provider Type Extensibility Source
  /// </summary>
  public string? CryptographicProviderTypeExtSource { get; set; }
  /// <summary>
  ///   Password Hash
  /// </summary>
  public IBase64Binary? Hash { get; set; }
  /// <summary>
  ///   Salt for Password Verifier
  /// </summary>
  public IBase64Binary? Salt { get; set; }
  /// <summary>
  ///   algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public string? AlgorithmName { get; set; }
  /// <summary>
  ///   hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public IBase64Binary? HashValue { get; set; }
  /// <summary>
  ///   saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public IBase64Binary? SaltValue { get; set; }
  /// <summary>
  ///   spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SpinCount { get; set; }
}