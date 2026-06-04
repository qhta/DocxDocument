namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageBorderZOrderValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues))]
public enum PageBorderZOrder
{
  /// <summary>
  ///   Page Border Ahead of Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues.Front))]
  Front,
  /// <summary>
  ///   Page Border Behind Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues.Back))]
  Back
}