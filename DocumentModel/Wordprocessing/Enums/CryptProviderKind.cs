namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CryptProviderValues enumeration.
/// </summary>
public enum CryptProviderKind
{
  /// <summary>
  ///   AES Provider.
  /// </summary>
  RsaAdvancedEncryptionStandard,

  /// <summary>
  ///   Any Provider.
  /// </summary>
  RsaFull,

  /// <summary>
  ///   custom.
  /// </summary>
  Custom
}