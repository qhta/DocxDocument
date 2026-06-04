namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptProviderValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Presentation.CryptProviderValues))]
public enum CryptProvider
{
  /// <summary>
  ///   AES Provider.
  /// </summary>
  RsaAdvancedEncryptionStandard,
  /// <summary>
  ///   Any Provider.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Presentation.CryptProviderValues.RsaFull))]
  RsaFull,
  /// <summary>
  ///   custom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Presentation.CryptProviderValues.Invalid))]
  Custom
}