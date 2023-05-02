namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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