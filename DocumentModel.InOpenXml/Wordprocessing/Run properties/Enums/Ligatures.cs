namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies ligature options for font rendering in WordprocessingML documents.
/// This enumeration provides values for different types and combinations of ligatures, supporting advanced typographic features and fine control over character joining in text content.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10W.LigaturesValues))]
public enum Ligatures
{
  /// <summary>
  /// No ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.None))]
  None,
  /// <summary>
  /// Standard ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.Standard))]
  Standard,
  /// <summary>
  /// Contextual ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.Contextual))]
  Contextual,
  /// <summary>
  /// Historical ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.Historical))]
  Historical,
  /// <summary>
  /// Discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.Discretional))]
  Discretional,
  /// <summary>
  /// Standard and contextual ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.StandardContextual))]
  StandardContextual,
  /// <summary>
  /// Standard and historical ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.StandardHistorical))]
  StandardHistorical,
  /// <summary>
  /// Contextual and historical ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.ContextualHistorical))]
  ContextualHistorical,
  /// <summary>
  /// Standard and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.StandardDiscretional))]
  StandardDiscretional,
  /// <summary>
  /// Contextual and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.ContextualDiscretional))]
  ContextualDiscretional,
  /// <summary>
  /// Historical and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.HistoricalDiscretional))]
  HistoricalDiscretional,
  /// <summary>
  /// Standard, contextual, and historical ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.StandardContextualHistorical))]
  StandardContextualHistorical,
  /// <summary>
  /// Standard, contextual, and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.StandardContextualDiscretional))]
  StandardContextualDiscretional,
  /// <summary>
  /// Standard, historical, and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.StandardHistoricalDiscretional))]
  StandardHistoricalDiscretional,
  /// <summary>
  /// Contextual, historical, and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.ContextualHistoricalDiscretional))]
  ContextualHistoricalDiscretional,
  /// <summary>
  /// All ligature types enabled.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.LigaturesValues.All))]
  All
}