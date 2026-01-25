namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the write protection settings applied to a WordprocessingML document.
/// This class provides properties for recommending write protection, cryptographic provider and algorithm details, password hash and salt, and extensibility options, enabling configuration and management of document write protection. Write protection restricts editing and saving the document under the same file name, but is not intended as a security feature.
/// </summary>
public partial class WriteProtection
{
  /// <summary>
  /// Recommend write protection in the user class.
  /// </summary>
  public bool? Recommended { get; set; }
  /// <summary>
  /// Cryptographic provider type used for write protection.
  /// </summary>
  public CryptProviderKind? CryptographicProviderType { get; set; }
  /// <summary>
  /// Cryptographic algorithm class used for write protection.
  /// </summary>
  public CryptAlgorithmClassKind? CryptographicAlgorithmClass { get; set; }
  /// <summary>
  /// Cryptographic algorithm type used for write protection.
  /// </summary>
  public CryptAlgorithmKind? CryptographicAlgorithmType { get; set; }
  /// <summary>
  /// Cryptographic hashing algorithm identifier.
  /// </summary>
  public Int32? CryptographicAlgorithmSid { get; set; }
  /// <summary>
  /// Number of iterations to run the hashing algorithm.
  /// </summary>
  public UInt32? CryptographicSpinCount { get; set; }
  /// <summary>
  /// FontName of the cryptographic provider.
  /// </summary>
  public string? CryptographicProvider { get; set; }
  /// <summary>
  /// Cryptographic algorithm extensibility identifier.
  /// </summary>
  public HexInt? AlgorithmIdExtensibility { get; set; }
  /// <summary>
  /// Source for the algorithm extensibility identifier.
  /// </summary>
  public string? AlgorithmIdExtensibilitySource { get; set; }
  /// <summary>
  /// Cryptographic provider type extensibility identifier.
  /// </summary>
  public HexInt? CryptographicProviderTypeExtensibility { get; set; }
  /// <summary>
  /// Source for the cryptographic provider type extensibility identifier.
  /// </summary>
  public string? CryptographicProviderTypeExtSource { get; set; }
  /// <summary>
  /// Password hash value for write protection.
  /// </summary>
  public Base64Binary? Hash { get; set; }
  /// <summary>
  /// Salt value for password verifier.
  /// </summary>
  public Base64Binary? Salt { get; set; }
  /// <summary>
  /// FontName of the specific cryptographic hashing algorithm used with the salt and input password.
  /// </summary>
  public string? AlgorithmName { get; set; }
  /// <summary>
  /// Hash value for write protection.
  /// </summary>
  public Base64Binary? HashValue { get; set; }
  /// <summary>
  /// Salt value for write protection.
  /// </summary>
  public Base64Binary? SaltValue { get; set; }
  /// <summary>
  /// Number of iterations (spin count) for hashing algorithm.
  /// </summary>
  public Int32? SpinCount { get; set; }
}