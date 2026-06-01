namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the IPictureFormat enumeration.
/// Used Iin types such as PictureOptions, IChartFormat, IInlineShape.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.PictureFormatValues))]
public enum IPictureFormat
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

