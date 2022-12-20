namespace DocxDocument.Model;

/// <summary>
/// Based on DocumentFormat.OpenXml.Wordprocessing.IWriteProtection class
/// </summary>
public class WriteProtection: DocxBasedElement<WD.WriteProtection>, IWriteProtection
{
  public WriteProtection() : base(new WD.WriteProtection())
  {
  }

  public WriteProtection(WD.WriteProtection element) : base(element)
  {
  }

  /// <summary>
  /// Cryptographic Algorithm Extensibility.
  /// </summary>
  public HexBinary? AlgorithmIdExtensibility
  {
    get => DocxRead.ReadHexBinary(DocxElement.AlgorithmIdExtensibility);
    set => DocxElement.AlgorithmIdExtensibility = (value != null) ? ((HexBinary)value).ToString() : null;
  }

  /// <summary>
  /// Algorithm Extensibility Source.
  /// </summary>
  public string? AlgorithmIdExtensibilitySource
  {
    get => DocxElement.AlgorithmIdExtensibilitySource?.Value;
    set => DocxElement.AlgorithmIdExtensibilitySource = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// AlgorithmName, this property is only available in Office2010.
  /// </summary>
  public string? AlgorithmName
  {
    get => DocxElement.AlgorithmName?.Value;
    set => DocxElement.AlgorithmName = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// Cryptographic Algorithm Class.
  /// </summary>
  public CryptAlgorithmClass? CryptographicAlgorithmClass
  {
    get => (DM.CryptAlgorithmClass?)DocxElement.CryptographicAlgorithmClass?.Value;
    set => DocxElement.CryptographicAlgorithmClass = (value != null) ? (WD.CryptAlgorithmClassValues)value : null;
  }

  /// <summary>
  /// Cryptographic Hashing Algorithm.
  /// </summary>
  public int? CryptographicAlgorithmSid
  {
    get => DocxElement.CryptographicAlgorithmSid?.Value;
    set => DocxElement.CryptographicAlgorithmSid = (value != null) ? (int)value : null;
  }

  /// <summary>
  /// Cryptographic Algorithm Type.
  /// </summary>
  public DM.CryptAlgorithmType? CryptographicAlgorithmType
  {
    get => (DM.CryptAlgorithmType?)DocxElement.CryptographicAlgorithmType?.Value;
    set => DocxElement.CryptographicAlgorithmType = (value != null) ? (WD.CryptAlgorithmValues)value : null;
  }

  /// <summary>
  /// Cryptographic Provider.
  /// </summary>
  public string? CryptographicProvider
  {
    get => DocxElement.CryptographicProvider?.Value;
    set => DocxElement.CryptographicProvider = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// Cryptographic Provider Type.
  /// </summary>
  public DM.CryptProviderType? CryptographicProviderType
  {
    get => (DM.CryptProviderType?)DocxElement.CryptographicProviderType?.Value;
    set => DocxElement.CryptographicProviderType = (value != null) ? (WD.CryptProviderValues)value : null;
  }

  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public HexBinary? CryptographicProviderTypeExtensibility
  {
    get => DocxRead.ReadHexBinary(DocxElement.CryptographicProviderTypeExtensibility);
    set => DocxElement.CryptographicProviderTypeExtensibility = (value != null) ? ((HexBinary)value).ToString() : null;
  }

  /// <summary>
  /// Provider Type Extensibility Source.
  /// </summary>
  public string? CryptographicProviderTypeExtSource
  {
    get => DocxElement.CryptographicProviderTypeExtSource?.Value;
    set => DocxElement.CryptographicProviderTypeExtSource = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// Iterations to Run Hashing Algorithm.
  /// </summary>
  public int? CryptographicSpinCount
  {
    get => (int?)DocxElement.CryptographicSpinCount?.Value;
    set => DocxElement.CryptographicSpinCount = (value != null) ? (uint)value : null;
  }

  /// <summary>
  /// Enforce Document Protection Settings.
  /// </summary>
  public bool? Recommended
  {
    get => DocxElement.Recommended?.Value;
    set => DocxElement.Recommended = (value != null) ? (bool)value : null;
  }

  /// <summary>
  /// Password Hash.
  /// </summary>
  public Base64Binary? Hash
  {
    get => DocxRead.ReadBase64Binary(DocxElement.Hash);
    set => DocxElement.Hash = (value != null) ? ((Base64Binary)value).ToString() : null;
  }

  /// <summary>
  /// HashValue, this property is only available in Office2010.
  /// </summary>
  public Base64Binary? HashValue
  {
    get => DocxRead.ReadBase64Binary(DocxElement.HashValue);
    set => DocxElement.HashValue = (value != null) ? ((Base64Binary)value).ToString() : null;
  }

  /// <summary>
  /// Salt for Password Verifier.
  /// </summary>
  public Base64Binary? Salt
  {
    get => DocxRead.ReadBase64Binary(DocxElement.Salt);
    set => DocxElement.Salt = (value != null) ? ((Base64Binary)value).ToString() : null;
  }

  /// <summary>
  /// SaltValue, this property is only available in Office2010.
  /// </summary>
  public Base64Binary? SaltValue
  {
    get => DocxRead.ReadBase64Binary(DocxElement.SaltValue);
    set => DocxElement.SaltValue = (value != null) ? ((Base64Binary)value).ToString() : null;
  }

  /// <summary>
  /// SpinCount, this property is only available in Office2010.
  /// </summary>
  public int? SpinCount
  {
    get => DocxElement.SpinCount?.Value;
    set => DocxElement.SpinCount = (value != null) ? (int)value : null;
  }
}