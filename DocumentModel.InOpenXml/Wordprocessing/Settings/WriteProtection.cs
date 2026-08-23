namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the write protection settings applied to a WordprocessingML document.
/// This class provides properties for recommending write protection, cryptographic provider and algorithm details, password hash and salt, and extensibility options, enabling configuration and management of document write protection. Write protection restricts editing and saving the document under the same file name, but is not intended as a security feature.
/// </summary>
[OpenXmlType(typeof(DXW.WriteProtection))]
[DataContract]
[XmlRoot("WriteProtection", Namespace = "DocumentModel.Wordprocessing")]
public partial class WriteProtection : ModelElement<DXW.WriteProtection>
{
  /// <summary>
  /// Recommend write protection in the user class.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.Recommended))]
  public bool? Recommended
  {
    get => _Recommended ??= GetProperty<bool?>(GetUpdatableElement()?.Recommended);
    set => UpdateField(ref _Recommended, value, nameof(Recommended));
  }
  private bool? _Recommended;

  /// <summary>
  /// Cryptographic provider type used for write protection.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.CryptographicProviderType))]
  [Obsolete]
  public CryptProvider? CryptographicProviderType
  {
    get => _CryptographicProviderType ??= GetProperty<CryptProvider?>(GetUpdatableElement()?.CryptographicProviderType);
    set => UpdateField(ref _CryptographicProviderType, value, nameof(CryptographicProviderType));
  }
  private CryptProvider? _CryptographicProviderType;

  /// <summary>
  /// Cryptographic algorithm class used for write protection.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.CryptographicAlgorithmClass))]
  [Obsolete]
  public CryptAlgorithmClass? CryptographicAlgorithmClass
  {
    get => _CryptographicAlgorithmClass ??=
      GetProperty<CryptAlgorithmClass?>(GetUpdatableElement()?.CryptographicAlgorithmClass);
    set => UpdateField(ref _CryptographicAlgorithmClass, value, nameof(CryptographicAlgorithmClass));
  }
  private CryptAlgorithmClass? _CryptographicAlgorithmClass;

  /// <summary>
  /// Cryptographic algorithm type used for write protection.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.CryptographicAlgorithmType))]
  [Obsolete]
  public CryptAlgorithm? CryptographicAlgorithmType
  {
    get => _CryptographicAlgorithmType ??=
      GetProperty<CryptAlgorithm?>(GetUpdatableElement()?.CryptographicAlgorithmType);
    set => UpdateField(ref _CryptographicAlgorithmType, value, nameof(CryptographicAlgorithmType));
  }
  private CryptAlgorithm? _CryptographicAlgorithmType;

  /// <summary>
  /// Cryptographic hashing algorithm identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.CryptographicAlgorithmSid))]
  [Obsolete]
  public Int32? CryptographicAlgorithmSid
  {
    get => _CryptographicAlgorithmSid ??= GetProperty<Int32?>(GetUpdatableElement()?.CryptographicAlgorithmSid);
    set => UpdateField(ref _CryptographicAlgorithmSid, value, nameof(CryptographicAlgorithmSid));
  }
  private Int32? _CryptographicAlgorithmSid;

  /// <summary>
  /// Number of iterations to run the hashing algorithm.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.CryptographicSpinCount))]
  [Obsolete]
  public UInt32? CryptographicSpinCount
  {
    get => _CryptographicSpinCount ??= GetProperty<UInt32?>(GetUpdatableElement()?.CryptographicSpinCount);
    set => UpdateField(ref _CryptographicSpinCount, value, nameof(CryptographicSpinCount));
  }
  private UInt32? _CryptographicSpinCount;

  /// <summary>
  /// Name of the cryptographic provider.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.CryptographicProvider))]
  [Obsolete]
  public string? CryptographicProvider
  {
    get => _CryptographicProvider ??= GetProperty<string?>(GetUpdatableElement()?.CryptographicProvider);
    set => UpdateField(ref _CryptographicProvider, value, nameof(CryptographicProvider));
  }
  private string? _CryptographicProvider;

  /// <summary>
  /// Cryptographic algorithm extensibility identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.AlgorithmIdExtensibility))]
  [Obsolete]
  public HexInt? AlgorithmIdExtensibility
  {
    get => _AlgorithmIdExtensibility ??= GetProperty<HexInt?>(GetUpdatableElement()?.AlgorithmIdExtensibility);
    set => UpdateField(ref _AlgorithmIdExtensibility, value, nameof(AlgorithmIdExtensibility));
  }
  private HexInt? _AlgorithmIdExtensibility;

  /// <summary>
  /// Source for the algorithm extensibility identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.AlgorithmIdExtensibilitySource))]
  [Obsolete]
  public string? AlgorithmIdExtensibilitySource
  {
    get => _AlgorithmIdExtensibilitySource ??=
      GetProperty<string?>(GetUpdatableElement()?.AlgorithmIdExtensibilitySource);
    set => UpdateField(ref _AlgorithmIdExtensibilitySource, value, nameof(AlgorithmIdExtensibilitySource));
  }
  private string? _AlgorithmIdExtensibilitySource;

  /// <summary>
  /// Cryptographic provider type extensibility identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.CryptographicProviderTypeExtensibility))]
  [Obsolete]
  public HexInt? CryptographicProviderTypeExtensibility
  {
    get => _CryptographicProviderTypeExtensibility ??=
      GetProperty<HexInt?>(GetUpdatableElement()?.CryptographicProviderTypeExtensibility);
    set => UpdateField(ref _CryptographicProviderTypeExtensibility, value,
      nameof(CryptographicProviderTypeExtensibility));
  }
  private HexInt? _CryptographicProviderTypeExtensibility;

  /// <summary>
  /// Source for the cryptographic provider type extensibility identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.CryptographicProviderTypeExtSource))]
  [Obsolete]
  public string? CryptographicProviderTypeExtSource
  {
    get => _CryptographicProviderTypeExtSource ??=
      GetProperty<string?>(GetUpdatableElement()?.CryptographicProviderTypeExtSource);
    set => UpdateField(ref _CryptographicProviderTypeExtSource, value, nameof(CryptographicProviderTypeExtSource));
  }
  private string? _CryptographicProviderTypeExtSource;

  /// <summary>
  /// Password hash value for write protection.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.Hash))]
  [Obsolete]
  public Base64Binary? Hash
  {
    get => _Hash ??= GetProperty<Base64Binary?>(GetUpdatableElement()?.Hash);
    set => UpdateField(ref _Hash, value, nameof(Hash));
  }
  private Base64Binary? _Hash;

  /// <summary>
  /// Salt value for password verifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.Salt))]
  [Obsolete]
  public Base64Binary? Salt
  {
    get => _Salt ??= GetProperty<Base64Binary?>(GetUpdatableElement()?.Salt);
    set => UpdateField(ref _Salt, value, nameof(Salt));
  }
  private Base64Binary? _Salt;

  /// <summary>
  /// Name of the specific cryptographic hashing algorithm used with the salt and input password.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.AlgorithmName))]
  [Obsolete]
  public string? AlgorithmName
  {
    get => _AlgorithmName ??= GetProperty<string?>(GetUpdatableElement()?.AlgorithmName);
    set => UpdateField(ref _AlgorithmName, value, nameof(AlgorithmName));
  }
  private string? _AlgorithmName;

  /// <summary>
  /// Hash value for write protection.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.HashValue))]
  public Base64Binary? HashValue
  {
    get => _HashValue ??= GetProperty<Base64Binary?>(GetUpdatableElement()?.HashValue);
    set => UpdateField(ref _HashValue, value, nameof(HashValue));
  }
  private Base64Binary? _HashValue;

  /// <summary>
  /// Salt value for write protection.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.SaltValue))]
  public Base64Binary? SaltValue
  {
    get => _SaltValue ??= GetProperty<Base64Binary?>(GetUpdatableElement()?.SaltValue);
    set => UpdateField(ref _SaltValue, value, nameof(SaltValue));
  }
  private Base64Binary? _SaltValue;

  /// <summary>
  /// Number of iterations (spin count) for hashing algorithm.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.WriteProtection.SpinCount))]
  public Int32? SpinCount
  {
    get => _SpinCount ??= GetProperty<Int32?>(GetUpdatableElement()?.SpinCount);
    set => UpdateField(ref _SpinCount, value, nameof(SpinCount));
  }
  private Int32? _SpinCount;
}