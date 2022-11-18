namespace DocumentModel.Presentation;

/// <summary>
/// Cryptographic Provider Type
/// </summary>
public enum CryptProvider
{
  /// <summary>
  /// RSA AES Encryption Scheme.
  /// </summary>
  [XmlEnum("rsaAES")]
  RsaAES,
  
  /// <summary>
  /// RSA Full Encryption Scheme.
  /// </summary>
  [XmlEnum("rsaFull")]
  RsaFull,
  
  /// <summary>
  /// Invalid Encryption Scheme.
  /// </summary>
  [XmlEnum("invalid")]
  Invalid,
  
}
