namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SizeRepresents enumeration.
/// Used in types such as BubbleChart, IChartGroup, BubbleChartConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues))]
public enum SizeRepresents
{
  /// <summary>
  ///   Bubble Size Represents Area.
  /// </summary>
  [OpenXmlEnumValue("Area")]
  Area,
  /// <summary>
  ///   Bubble Size Represents Width.
  /// </summary>
  [OpenXmlEnumValue("Width")]
  Width
}

