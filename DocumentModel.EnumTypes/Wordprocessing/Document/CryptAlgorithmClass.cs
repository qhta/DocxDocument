namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptAlgorithmClassValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues))]
public enum CryptAlgorithmClass
{
  /// <summary>
  ///   Hashing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues.Hash))]
  Hash,
  /// <summary>
  ///   custom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues.Custom))]
  Custom
}