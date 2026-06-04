namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptAlgorithmClassValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Presentation.CryptAlgorithmClassValues))]
public enum CryptAlgorithmClass
{
  /// <summary>
  ///   Hashing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Presentation.CryptAlgorithmClassValues.Hash))]
  Hash,
  /// <summary>
  ///   custom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Presentation.CryptAlgorithmClassValues.Invalid))]
  Custom
}