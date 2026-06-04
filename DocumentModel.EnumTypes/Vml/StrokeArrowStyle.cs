namespace DocumentModel.Vml;
/// <summary>
///   Stroke Arrowhead Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.StrokeArrowValues))]
public enum StrokeArrowStyle
{
  /// <summary>
  ///   No Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowValues.None))]
  None,
  /// <summary>
  ///   Block Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowValues.Block))]
  Block,
  /// <summary>
  ///   Classic Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowValues.Classic))]
  Classic,
  /// <summary>
  ///   Oval Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowValues.Oval))]
  Oval,
  /// <summary>
  ///   Diamond Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowValues.Diamond))]
  Diamond,
  /// <summary>
  ///   Open Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeArrowValues.Open))]
  Open
}