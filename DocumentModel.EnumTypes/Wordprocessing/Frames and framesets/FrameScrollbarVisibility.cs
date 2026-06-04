namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FrameScrollbarVisibilityValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues))]
public enum FrameScrollbarVisibility
{
  /// <summary>
  ///   Always Show Scrollbar.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues.On))]
  On,
  /// <summary>
  ///   Never Show Scrollbar.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues.Off))]
  Off,
  /// <summary>
  ///   Automatically Show Scrollbar As Needed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues.Auto))]
  Auto
}