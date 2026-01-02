namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the write protection settings which have been applied to a WordprocessingML document.
///   Write protection refers to a mode in which the document's contents cannot be edited, and the document cannot
///   be resaved using the same file name. This setting is independent of the documentProtection (§17.15.1.29)
///  element, but like document protection, this setting is not intended as a security feature and can be ignored.
/// </summary>
public interface IWriteProtection: IModelElement
{
  /// <summary>
  ///   Recommend Write Protection in User Interface
  /// </summary>
  public bool? Recommended { get; set; }
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
  ///   Specifies the specific cryptographic hashing algorithm which shall be used along with the
  ///   salt attribute and input password in order to compute the hash value.
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