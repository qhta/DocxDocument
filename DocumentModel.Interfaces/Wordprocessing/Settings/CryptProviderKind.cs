namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CryptProviderValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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