namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptAlgorithmValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues))]
public enum CryptAlgorithm
{
  /// <summary>
  ///   Any Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues.TypeAny))]
  TypeAny,
  /// <summary>
  ///   custom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues.Custom))]
  Custom
}