namespace DocumentModel.Drawings;
/// <summary>
///   Defines the TargetScreenSize enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TargetScreenSizeValues))]
public enum TargetScreenSize
{
  /// <summary>
  ///   544x376.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz544x376))]
  Sz544x376,
  /// <summary>
  ///   640x480.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz640x480))]
  Sz640x480,
  /// <summary>
  ///   720x512.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz720x512))]
  Sz720x512,
  /// <summary>
  ///   800x600.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz800x600))]
  Sz800x600,
  /// <summary>
  ///   1024x768.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz1024x768))]
  Sz1024x768,
  /// <summary>
  ///   1152x882.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz1152x882))]
  Sz1152x882,
  /// <summary>
  ///   1152x900.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz1152x900))]
  Sz1152x900,
  /// <summary>
  ///   1280x1024.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz1280x1024))]
  Sz1280x1024,
  /// <summary>
  ///   1600x1200.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz1600x1200))]
  Sz1600x1200,
  /// <summary>
  ///   1800x1440.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz1800x1440))]
  Sz1800x1440,
  /// <summary>
  ///   1920x1200.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TargetScreenSizeValues.Sz1920x1200))]
  Sz1920x1200
}