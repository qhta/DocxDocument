namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document Editing Restrictions.
/// </summary>
public class DocumentProtection: ModelElement
{
  /// <summary>
  ///   Document Editing Restrictions
  /// </summary>
  public DocumentProtectionKind? Edit { get; set; }

  /// <summary>
  ///   Only Allow Formatting With Unlocked Styles
  /// </summary>
  public Boolean? Formatting { get; set; }

  /// <summary>
  ///   Enforce Document Protection Settings
  /// </summary>
  public Boolean? Enforcement { get; set; }

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
  public String? CryptographicProvider { get; set; }

  /// <summary>
  ///   Cryptographic Algorithm Extensibility
  /// </summary>
  public HexInt? AlgorithmIdExtensibility { get; set; }

  /// <summary>
  ///   Algorithm Extensibility Source
  /// </summary>
  public String? AlgorithmIdExtensibilitySource { get; set; }

  /// <summary>
  ///   Cryptographic Provider Type Extensibility
  /// </summary>
  public HexInt? CryptographicProviderTypeExtensibility { get; set; }

  /// <summary>
  ///   Provider Type Extensibility Source
  /// </summary>
  public String? CryptographicProviderTypeExtSource { get; set; }

  /// <summary>
  ///   Password Hash
  /// </summary>
  public Base64Binary? Hash { get; set; }

  /// <summary>
  ///   Salt for Password Verifier
  /// </summary>
  public Base64Binary? Salt { get; set; }

  /// <summary>
  ///   algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AlgorithmName { get; set; }

  /// <summary>
  ///   hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public Base64Binary? HashValue { get; set; }

  /// <summary>
  ///   saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public Base64Binary? SaltValue { get; set; }

  /// <summary>
  ///   spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SpinCount { get; set; }
}