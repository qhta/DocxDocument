namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PresetZoomValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues))]
public enum PresetZoom
{
  /// <summary>
  ///   No Preset Magnification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues.None))]
  None,
  /// <summary>
  ///   Display One Full Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues.FullPage))]
  FullPage,
  /// <summary>
  ///   Display Page Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues.BestFit))]
  BestFit,
  /// <summary>
  ///   Display Text Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues.TextFit))]
  TextFit
}