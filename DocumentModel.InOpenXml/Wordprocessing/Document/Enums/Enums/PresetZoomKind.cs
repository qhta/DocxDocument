namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PresetZoomValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.PresetZoomValues))]
public enum PresetZoomKind
{
  /// <summary>
  ///   No Preset Magnification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PresetZoomValues.None))]
  None,
  /// <summary>
  ///   Display One Full Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PresetZoomValues.FullPage))]
  FullPage,
  /// <summary>
  ///   Display Page Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PresetZoomValues.BestFit))]
  BestFit,
  /// <summary>
  ///   Display Text Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PresetZoomValues.TextFit))]
  TextFit
}