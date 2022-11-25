namespace DocumentModel.Presentation;

/// <summary>
/// Cryptographic Provider Type
/// </summary>
public enum CryptProviderKind
{
  /// <summary>
  /// RSA AES Encryption Scheme.
  /// </summary>
  RsaAES,
  
  /// <summary>
  /// RSA Full Encryption Scheme.
  /// </summary>
  RsaFull,
  
  /// <summary>
  /// Invalid Encryption Scheme.
  /// </summary>
  Invalid,
  
}
