namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PictureFormat enumeration.
/// Used in types such as PictureOptions, ChartFormat, InlineShape.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.PictureFormatValues))]
public enum PictureFormat
{
  /// <summary>
  ///   Stretch.
  /// </summary>
  [OpenXmlEnumValue("Stretch")]
  Stretch,
  /// <summary>
  ///   Stack.
  /// </summary>
  [OpenXmlEnumValue("Stack")]
  Stack,
  /// <summary>
  ///   Stack and Scale.
  /// </summary>
  [OpenXmlEnumValue("StackScale")]
  StackScale
}
