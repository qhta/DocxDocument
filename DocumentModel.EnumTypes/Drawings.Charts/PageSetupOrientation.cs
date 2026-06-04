namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PageSetupOrientation enumeration.
/// Used in types such as IPageSetup.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues))]
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

