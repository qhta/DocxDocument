namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageOrientationValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues))]
public enum PageOrientation
{
  /// <summary>
  ///   Portrait Mode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues.Portrait))]
  Portrait = 1,

  /// <summary>
  ///   Landscape Mode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues.Landscape))]
  Landscape
}