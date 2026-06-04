namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptAlgorithmValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Presentation.CryptAlgorithmValues))]
public enum CryptAlgorithm
{
  /// <summary>
  ///   Any Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Presentation.CryptAlgorithmValues.TypeAny))]
  TypeAny,
  /// <summary>
  ///   custom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Presentation.CryptAlgorithmValues.Invalid))]
  Custom
}