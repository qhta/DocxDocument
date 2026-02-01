namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FrameScrollbarVisibilityValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FrameScrollbarVisibilityValues))]
public enum FrameScrollbarVisibilityKind
{
  /// <summary>
  ///   Always Show Scrollbar.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FrameScrollbarVisibilityValues.On))]
  On,
  /// <summary>
  ///   Never Show Scrollbar.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FrameScrollbarVisibilityValues.Off))]
  Off,
  /// <summary>
  ///   Automatically Show Scrollbar As Needed.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FrameScrollbarVisibilityValues.Auto))]
  Auto
}