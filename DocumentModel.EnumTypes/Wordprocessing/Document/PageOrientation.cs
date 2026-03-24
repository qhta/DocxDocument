namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageOrientationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.PageOrientationValues))]
public enum PageOrientation
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Portrait Mode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageOrientationValues.Portrait))]
  Portrait = 1,

  /// <summary>
  ///   Landscape Mode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageOrientationValues.Landscape))]
  Landscape
}