namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageOrientation enumeration.
/// Used in types such as PageSetup, PageOrientation, PageSize.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageOrientation
{
  /// <summary>
  ///   default.
  /// </summary>
  [OpenXmlEnumValue("Default")]
  Default,
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
