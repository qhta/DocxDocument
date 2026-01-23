namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents document editing restrictions and protection settings in a WordprocessingML document.
/// This class provides properties for editing restrictions, formatting limitations, enforcement, cryptographic settings, password protection, and hashing details, enabling advanced security and access control for document editing and formatting.
/// </summary>
public partial class DocumentProtection : ModelElement<DXW.DocumentProtection>
{
    /// <summary>
    /// Document editing restrictions, specifying the allowed editing mode (e.g., read-only, tracked changes, comments).
    /// </summary>
    public DocumentProtectionKind? Edit { get => _Edit; set => UpdateField(ref _Edit, value, nameof(Edit)); }

    private DocumentProtectionKind? _Edit;
    /// <summary>
    /// Indicates whether only formatting with unlocked styles is allowed.
    /// </summary>
    public bool? Formatting { get; set; }
    /// <summary>
    /// Indicates whether document protection settings are enforced.
    /// </summary>
    public bool? Enforcement { get; set; }
    /// <summary>
    /// Cryptographic provider type used for document protection.
    /// </summary>
    public CryptProviderKind? CryptographicProviderType { get; set; }
    /// <summary>
    /// Cryptographic algorithm class used for document protection.
    /// </summary>
    public CryptAlgorithmClassKind? CryptographicAlgorithmClass { get; set; }
    /// <summary>
    /// Cryptographic algorithm type used for document protection.
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
    /// Name of the cryptographic provider used for document protection.
    /// </summary>
    public string? CryptographicProvider { get; set; }
    /// <summary>
    /// Cryptographic algorithm extensibility identifier.
    /// </summary>
    public HexInt? AlgorithmIdExtensibility { get; set; }
    /// <summary>
    /// Source of the algorithm extensibility identifier.
    /// </summary>
    public string? AlgorithmIdExtensibilitySource { get; set; }
    /// <summary>
    /// Cryptographic provider type extensibility identifier.
    /// </summary>
    public HexInt? CryptographicProviderTypeExtensibility { get; set; }
    /// <summary>
    /// Source of the cryptographic provider type extensibility identifier.
    /// </summary>
    public string? CryptographicProviderTypeExtSource { get; set; }
    /// <summary>
    /// Password hash for document protection.
    /// </summary>
    public Base64Binary? Hash { get; set; }
    /// <summary>
    /// Salt value for the password verifier.
    /// </summary>
    public Base64Binary? Salt { get; set; }
    /// <summary>
    /// Name of the cryptographic algorithm used for document protection.
    /// </summary>
    public string? AlgorithmName { get; set; }
    /// <summary>
    /// Hash value for document protection.
    /// </summary>
    public Base64Binary? HashValue { get; set; }
    /// <summary>
    /// Salt value for document protection.
    /// </summary>
    public Base64Binary? SaltValue { get; set; }
    /// <summary>
    /// Number of spin count iterations for hashing.
    /// </summary>
    public Int32? SpinCount { get; set; }
}