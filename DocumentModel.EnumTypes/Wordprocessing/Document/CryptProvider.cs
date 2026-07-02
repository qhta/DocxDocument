namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptProviderValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues))]
public enum CryptProvider
{
  /// <summary>
  ///   AES Provider.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues.RsaAdvancedEncryptionStandard))]
  RsaAdvancedEncryptionStandard,
  /// <summary>
  ///   Any Provider.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues.RsaFull))]
  RsaFull,
  /// <summary>
  ///   custom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues.Custom))]
  Custom
}