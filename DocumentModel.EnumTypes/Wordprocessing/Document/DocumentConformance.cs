namespace DocumentModel.Wordprocessing;
/// <summary>
///  Specifies the document conformance mode for a WordprocessingML document.
///  This enumeration provides values for transitional and strict conformance, supporting compatibility and validation against different versions of the Open XML standard.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DocumentConformance))]
public enum DocumentConformance
{
  /// <summary>
  /// Transitional conformance mode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentConformance.transitional))]
  Transitional,
  /// <summary>
  /// Strict conformance mode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentConformance.strict))]
  Strict
}