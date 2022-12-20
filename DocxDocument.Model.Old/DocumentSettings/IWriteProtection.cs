namespace DocxDocument.Model;

/// <summary>
/// Based on DocumentFormat.OpenXml.Wordprocessing.IWriteProtection class
/// </summary>
public interface IWriteProtection
{
  /// <summary>
  /// Cryptographic Algorithm Extensibility.
  /// </summary>
  public HexBinary? AlgorithmIdExtensibility { get; set;}

  /// <summary>
  /// Algorithm Extensibility Source.
  /// </summary>
  public string? AlgorithmIdExtensibilitySource { get; set; }

  /// <summary>
  /// AlgorithmName, this property is only available in Office2010.
  /// </summary>
  public string? AlgorithmName { get; set;}

  /// <summary>
  /// Cryptographic Algorithm Class.
  /// </summary>
  public DM.CryptAlgorithmClass? CryptographicAlgorithmClass { get; set; }

  /// <summary>
  /// Cryptographic Hashing Algorithm.
  /// </summary>
  public int? CryptographicAlgorithmSid { get; set; }

  /// <summary>
  /// Cryptographic Algorithm Type.
  /// </summary>
  public DM.CryptAlgorithmType? CryptographicAlgorithmType { get; set; }

  /// <summary>
  /// Cryptographic Provider.
  /// </summary>
  public string? CryptographicProvider { get; set; }

  /// <summary>
  /// Cryptographic Provider Type.
  /// </summary>
  public DM.CryptProviderType? CryptographicProviderType { get; set; }

  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public HexBinary? CryptographicProviderTypeExtensibility { get; set; }

  /// <summary>
  /// Provider Type Extensibility Source.
  /// </summary>
  public string? CryptographicProviderTypeExtSource { get; set; }

  /// <summary>
  /// Iterations to Run Hashing Algorithm.
  /// </summary>
  public int? CryptographicSpinCount { get; set; }

  /// <summary>
  /// Password Hash.
  /// </summary>
  public Base64Binary? Hash { get; set; }

  /// <summary>
  /// HashValue, this property is only available in Office2010.
  /// </summary>
  public Base64Binary? HashValue { get; set; }

  /// <summary>
  /// Recommend Write Protection in User Interface
  /// </summary>
  public bool? Recommended { get; set; }

  /// <summary>
  /// Salt for Password Verifier.
  /// </summary>
  public Base64Binary? Salt { get; set; }

  /// <summary>
  /// SaltValue, this property is only available in Office2010.
  /// </summary>
  public Base64Binary? SaltValue { get; set; }

  /// <summary>
  /// SpinCount, this property is only available in Office2010.
  /// </summary>
  public int? SpinCount { get; set; }
}