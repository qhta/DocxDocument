namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the IPictureFormat enumeration.
/// Used in types such as PictureOptions, IChartFormat, IInlineShape.
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

