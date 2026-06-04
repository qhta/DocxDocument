namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies ligature options for font rendering in WordprocessingML documents.
/// This enumeration provides values for different types and combinations of ligatures, supporting advanced typographic features and fine control over character joining in text content.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues))]
public enum Ligatures
{
  /// <summary>
  /// No ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.None))]
  None,
  /// <summary>
  /// Standard ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.Standard))]
  Standard,
  /// <summary>
  /// Contextual ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.Contextual))]
  Contextual,
  /// <summary>
  /// Historical ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.Historical))]
  Historical,
  /// <summary>
  /// Discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.Discretional))]
  Discretional,
  /// <summary>
  /// Standard and contextual ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.StandardContextual))]
  StandardContextual,
  /// <summary>
  /// Standard and historical ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.StandardHistorical))]
  StandardHistorical,
  /// <summary>
  /// Contextual and historical ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.ContextualHistorical))]
  ContextualHistorical,
  /// <summary>
  /// Standard and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.StandardDiscretional))]
  StandardDiscretional,
  /// <summary>
  /// Contextual and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.ContextualDiscretional))]
  ContextualDiscretional,
  /// <summary>
  /// Historical and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.HistoricalDiscretional))]
  HistoricalDiscretional,
  /// <summary>
  /// Standard, contextual, and historical ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.StandardContextualHistorical))]
  StandardContextualHistorical,
  /// <summary>
  /// Standard, contextual, and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.StandardContextualDiscretional))]
  StandardContextualDiscretional,
  /// <summary>
  /// Standard, historical, and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.StandardHistoricalDiscretional))]
  StandardHistoricalDiscretional,
  /// <summary>
  /// Contextual, historical, and discretional ligatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.ContextualHistoricalDiscretional))]
  ContextualHistoricalDiscretional,
  /// <summary>
  /// All ligature types enabled.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.LigaturesValues.All))]
  All
}