namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents document editing restrictions and protection settings in a WordprocessingML document.
/// This class provides properties for editing restrictions, formatting limitations, enforcement, cryptographic settings, password protection, and hashing details, enabling advanced security and access control for document editing and formatting.
/// </summary>
[OpenXmlType(typeof(DXW.DocumentProtection))]
[DataContract]
[XmlRoot("DocumentProtection", Namespace = "DocumentModel.Wordprocessing")]
public partial class DocumentProtection : ModelElement<DXW.DocumentProtection>
{
 /// <summary>
 /// Document editing restrictions, specifying the allowed editing mode (e.g., read-only, tracked changes, comments).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.Edit))]
 public DocumentProtectionType? Edit { get => _Edit; set => UpdateField(ref _Edit, value, nameof(Edit)); }
 private DocumentProtectionType? _Edit;

 /// <summary>
 /// Indicates whether only formatting with unlocked styles is allowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.Formatting))]
 public bool? Formatting { get => _Formatting; set => UpdateField(ref _Formatting, value, nameof(Formatting)); }
 private bool? _Formatting;

 /// <summary>
 /// Indicates whether document protection settings are enforced.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.Enforcement))]
 public bool? Enforcement { get => _Enforcement; set => UpdateField(ref _Enforcement, value, nameof(Enforcement)); }
 private bool? _Enforcement;

 /// <summary>
 /// Cryptographic provider type used for document protection.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.CryptographicProviderType))]
 public CryptProvider? CryptographicProviderType { get => _CryptographicProviderType; set => UpdateField(ref _CryptographicProviderType, value, nameof(CryptographicProviderType)); }
 private CryptProvider? _CryptographicProviderType;

 /// <summary>
 /// Cryptographic algorithm class used for document protection.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.CryptographicAlgorithmClass))]
 public CryptAlgorithmClass? CryptographicAlgorithmClass { get => _CryptographicAlgorithmClass; set => UpdateField(ref _CryptographicAlgorithmClass, value, nameof(CryptographicAlgorithmClass)); }
 private CryptAlgorithmClass? _CryptographicAlgorithmClass;

 /// <summary>
 /// Cryptographic algorithm type used for document protection.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.CryptographicAlgorithmType))]
 public CryptAlgorithm? CryptographicAlgorithmType { get => _CryptographicAlgorithmType; set => UpdateField(ref _CryptographicAlgorithmType, value, nameof(CryptographicAlgorithmType)); }
 private CryptAlgorithm? _CryptographicAlgorithmType;

 /// <summary>
 /// Cryptographic hashing algorithm identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.CryptographicAlgorithmSid))]
 public Int32? CryptographicAlgorithmSid { get => _CryptographicAlgorithmSid; set => UpdateField(ref _CryptographicAlgorithmSid, value, nameof(CryptographicAlgorithmSid)); }
 private Int32? _CryptographicAlgorithmSid;

 /// <summary>
 /// Number of iterations to run the hashing algorithm.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.CryptographicSpinCount))]
 public UInt32? CryptographicSpinCount { get => _CryptographicSpinCount; set => UpdateField(ref _CryptographicSpinCount, value, nameof(CryptographicSpinCount)); }
 private UInt32? _CryptographicSpinCount;

 /// <summary>
 /// Name of the cryptographic provider used for document protection.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.CryptographicProvider))]
 public string? CryptographicProvider { get => _CryptographicProvider; set => UpdateField(ref _CryptographicProvider, value, nameof(CryptographicProvider)); }
 private string? _CryptographicProvider;

 /// <summary>
 /// Cryptographic algorithm extensibility identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.AlgorithmIdExtensibility))]
 public HexInt? AlgorithmIdExtensibility { get => _AlgorithmIdExtensibility; set => UpdateField(ref _AlgorithmIdExtensibility, value, nameof(AlgorithmIdExtensibility)); }
 private HexInt? _AlgorithmIdExtensibility;

 /// <summary>
 /// Source of the algorithm extensibility identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.AlgorithmIdExtensibilitySource))]
 public string? AlgorithmIdExtensibilitySource { get => _AlgorithmIdExtensibilitySource; set => UpdateField(ref _AlgorithmIdExtensibilitySource, value, nameof(AlgorithmIdExtensibilitySource)); }
 private string? _AlgorithmIdExtensibilitySource;

 /// <summary>
 /// Cryptographic provider type extensibility identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.CryptographicProviderTypeExtensibility))]
 public HexInt? CryptographicProviderTypeExtensibility { get => _CryptographicProviderTypeExtensibility; set => UpdateField(ref _CryptographicProviderTypeExtensibility, value, nameof(CryptographicProviderTypeExtensibility)); }
 private HexInt? _CryptographicProviderTypeExtensibility;

 /// <summary>
 /// Source of the cryptographic provider type extensibility identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.CryptographicProviderTypeExtSource))]
 public string? CryptographicProviderTypeExtSource { get => _CryptographicProviderTypeExtSource; set => UpdateField(ref _CryptographicProviderTypeExtSource, value, nameof(CryptographicProviderTypeExtSource)); }
 private string? _CryptographicProviderTypeExtSource;

 /// <summary>
 /// Password hash for document protection.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.Hash))]
 public Base64Binary? Hash { get => _Hash; set => UpdateField(ref _Hash, value, nameof(Hash)); }
 private Base64Binary? _Hash;

 /// <summary>
 /// Salt value for the password verifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.Salt))]
 public Base64Binary? Salt { get => _Salt; set => UpdateField(ref _Salt, value, nameof(Salt)); }
 private Base64Binary? _Salt;

 /// <summary>
 /// Name of the cryptographic algorithm used for document protection.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.AlgorithmName))]
 public string? AlgorithmName { get => _AlgorithmName; set => UpdateField(ref _AlgorithmName, value, nameof(AlgorithmName)); }
 private string? _AlgorithmName;

 /// <summary>
 /// Hash value for document protection.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.HashValue))]
 public Base64Binary? HashValue { get => _HashValue; set => UpdateField(ref _HashValue, value, nameof(HashValue)); }
 private Base64Binary? _HashValue;

 /// <summary>
 /// Salt value for document protection.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.SaltValue))]
 public Base64Binary? SaltValue { get => _SaltValue; set => UpdateField(ref _SaltValue, value, nameof(SaltValue)); }
 private Base64Binary? _SaltValue;

 /// <summary>
 /// Number of spin count iterations for hashing.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentProtection.SpinCount))]
 public Int32? SpinCount { get => _SpinCount; set => UpdateField(ref _SpinCount, value, nameof(SpinCount)); }
 private Int32? _SpinCount;
}