namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageOrientation enumeration.
/// Used in types such as PageSetup, PageOrientation, PageSize.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageOrientation
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   default.
  /// </summary>
  [OpenXmlEnumValue("Default")]
  Default = 1,

  /// <summary>
  ///   portrait.
  /// </summary>
  [OpenXmlEnumValue("Portrait")]
  Portrait,
  /// <summary>
  ///   landscape.
  /// </summary>
  [OpenXmlEnumValue("Landscape")]
  Landscape
}
