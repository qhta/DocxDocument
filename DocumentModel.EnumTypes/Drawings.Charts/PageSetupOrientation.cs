namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PageSetupOrientation enumeration.
/// Used Iin types such as IPageSetup.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.PageSetupOrientationValues))]
public enum PageSetupOrientation
{
  /// <summary>
  ///   Default IPage Orientation.
  /// </summary>
  [OpenXmlEnumValue("Default")]
  Default = 1,

  /// <summary>
  ///   Portrait IPage.
  /// </summary>
  [OpenXmlEnumValue("Portrait")]
  Portrait,
  /// <summary>
  ///   Landscape IPage.
  /// </summary>
  [OpenXmlEnumValue("Landscape")]
  Landscape
}

