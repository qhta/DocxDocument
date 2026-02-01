namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptProviderValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXP.CryptProviderValues))]
public enum CryptProviderKind
{
  /// <summary>
  ///   AES Provider.
  /// </summary>
  RsaAdvancedEncryptionStandard,
  /// <summary>
  ///   Any Provider.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXP.CryptProviderValues.RsaFull))]
  RsaFull,
  /// <summary>
  ///   custom.
  /// </summary>
  Custom
}