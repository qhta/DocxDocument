namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PageSetupOrientation enumeration.
/// Used in types such as PageSetup.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.PageSetupOrientationValues))]
public enum PageSetupOrientation
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Default Page Orientation.
  /// </summary>
  [OpenXmlEnumValue("Default")]
  Default = 1,

  /// <summary>
  ///   Portrait Page.
  /// </summary>
  [OpenXmlEnumValue("Portrait")]
  Portrait,
  /// <summary>
  ///   Landscape Page.
  /// </summary>
  [OpenXmlEnumValue("Landscape")]
  Landscape
}
