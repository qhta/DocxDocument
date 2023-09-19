namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document Editing Restrictions.
/// </summary>
public partial class DocumentProtection
{
  
  /// <summary>
  ///   Document Editing Restrictions
  /// </summary>
  [SchemaAttr("w:edit")]
  public DocumentModel.Wordprocessing.DocumentProtectionValues? Edit { get; set; }
  
  
  /// <summary>
  ///   Only Allow Formatting With Unlocked Styles
  /// </summary>
  [SchemaAttr("w:formatting")]
  public Boolean? Formatting { get; set; }
  
  
  /// <summary>
  ///   Enforce Document Protection Settings
  /// </summary>
  [SchemaAttr("w:enforcement")]
  public Boolean? Enforcement { get; set; }
  
  
  /// <summary>
  ///   Cryptographic Provider Type
  /// </summary>
  [SchemaAttr("w:cryptProviderType")]
  public DocumentModel.Wordprocessing.CryptProviderValues? CryptographicProviderType { get; set; }
  
  
  /// <summary>
  ///   Cryptographic Algorithm Class
  /// </summary>
  [SchemaAttr("w:cryptAlgorithmClass")]
  public DocumentModel.Wordprocessing.CryptAlgorithmClassValues? CryptographicAlgorithmClass { get; set; }
  
  
  /// <summary>
  ///   Cryptographic Algorithm Type
  /// </summary>
  [SchemaAttr("w:cryptAlgorithmType")]
  public DocumentModel.Wordprocessing.CryptAlgorithmValues? CryptographicAlgorithmType { get; set; }
  
  
  /// <summary>
  ///   Cryptographic Hashing Algorithm
  /// </summary>
  [SchemaAttr("w:cryptAlgorithmSid")]
  public Int32? CryptographicAlgorithmSid { get; set; }
  
  
  /// <summary>
  ///   Iterations to Run Hashing Algorithm
  /// </summary>
  [SchemaAttr("w:cryptSpinCount")]
  public UInt32? CryptographicSpinCount { get; set; }
  
  
  /// <summary>
  ///   Cryptographic Provider
  /// </summary>
  [SchemaAttr("w:cryptProvider")]
  public String? CryptographicProvider { get; set; }
  
  
  /// <summary>
  ///   Cryptographic Algorithm Extensibility
  /// </summary>
  [SchemaAttr("w:algIdExt")]
  public DocumentModel.HexBinaryValue? AlgorithmIdExtensibility { get; set; }
  
  
  /// <summary>
  ///   Algorithm Extensibility Source
  /// </summary>
  [SchemaAttr("w:algIdExtSource")]
  public String? AlgorithmIdExtensibilitySource { get; set; }
  
  
  /// <summary>
  ///   Cryptographic Provider Type Extensibility
  /// </summary>
  [SchemaAttr("w:cryptProviderTypeExt")]
  public DocumentModel.HexBinaryValue? CryptographicProviderTypeExtensibility { get; set; }
  
  
  /// <summary>
  ///   Provider Type Extensibility Source
  /// </summary>
  [SchemaAttr("w:cryptProviderTypeExtSource")]
  public String? CryptographicProviderTypeExtSource { get; set; }
  
  
  /// <summary>
  ///   Password Hash
  /// </summary>
  [SchemaAttr("w:hash")]
  public DocumentModel.Base64BinaryValue? Hash { get; set; }
  
  
  /// <summary>
  ///   Salt for Password Verifier
  /// </summary>
  [SchemaAttr("w:salt")]
  public DocumentModel.Base64BinaryValue? Salt { get; set; }
  
  
  /// <summary>
  ///   algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:algorithmName")]
  public String? AlgorithmName { get; set; }
  
  
  /// <summary>
  ///   hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:hashValue")]
  public DocumentModel.Base64BinaryValue? HashValue { get; set; }
  
  
  /// <summary>
  ///   saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:saltValue")]
  public DocumentModel.Base64BinaryValue? SaltValue { get; set; }
  
  
  /// <summary>
  ///   spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w:spinCount")]
  public Int32? SpinCount { get; set; }
  
}
