namespace DocumentModel.Vml;
/// <summary>
///   Stroke Arrowhead Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.StrokeArrowValues))]
public enum StrokeArrowKind
{
  /// <summary>
  ///   No Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowValues.None))]
  None,
  /// <summary>
  ///   Block Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowValues.Block))]
  Block,
  /// <summary>
  ///   Classic Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowValues.Classic))]
  Classic,
  /// <summary>
  ///   Oval Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowValues.Oval))]
  Oval,
  /// <summary>
  ///   Diamond Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowValues.Diamond))]
  Diamond,
  /// <summary>
  ///   Open Arrowhead.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeArrowValues.Open))]
  Open
}