namespace DocumentModel.Wordprocessing;

/// <summary>
/// Write Protection.
/// </summary>
public interface IWriteProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Recommend Write Protection in User Interface
  /// </summary>
  public bool? Recommended { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public DocumentModel.Wordprocessing.CryptProvider? CryptographicProviderType { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public DocumentModel.Wordprocessing.CryptAlgorithmClass? CryptographicAlgorithmClass { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public DocumentModel.Wordprocessing.CryptAlgorithm? CryptographicAlgorithmType { get ; set; }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public int? CryptographicAlgorithmSid { get ; set; }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public uint? CryptographicSpinCount { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public string? CryptographicProvider { get ; set; }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public IHexBinaryValue? AlgorithmIdExtensibility { get ; set; }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public string? AlgorithmIdExtensibilitySource { get ; set; }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public IHexBinaryValue? CryptographicProviderTypeExtensibility { get ; set; }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public string? CryptographicProviderTypeExtSource { get ; set; }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public IBase64BinaryValue? Hash { get ; set; }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public IBase64BinaryValue? Salt { get ; set; }
  
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
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public int? SpinCount { get ; set; }
  
}
