namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageOrientationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.PageOrientationValues))]
public enum PageOrientationKind
{
  /// <summary>
  ///   Portrait Mode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageOrientationValues.Portrait))]
  Portrait,
  /// <summary>
  ///   Landscape Mode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageOrientationValues.Landscape))]
  Landscape
}