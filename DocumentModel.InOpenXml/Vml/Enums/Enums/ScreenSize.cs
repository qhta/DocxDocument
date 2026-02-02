namespace DocumentModel.Vml;
/// <summary>
///   Screen Sizes Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.ScreenSizeValues))]
public enum ScreenSize
{
  /// <summary>
  ///   544x376 pixels.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ScreenSizeValues.Sz544x376))]
  Sz544x376,
  /// <summary>
  ///   640x480 pixels.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ScreenSizeValues.Sz640x480))]
  Sz640x480,
  /// <summary>
  ///   720x512 pixels.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ScreenSizeValues.Sz720x512))]
  Sz720x512,
  /// <summary>
  ///   800x600 pixels.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ScreenSizeValues.Sz800x600))]
  Sz800x600,
  /// <summary>
  ///   1024x768 pixels.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ScreenSizeValues.Sz1024x768))]
  Sz1024x768,
  /// <summary>
  ///   1152x862 pixels.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.ScreenSizeValues.Sz1152x862))]
  Sz1152x862
}