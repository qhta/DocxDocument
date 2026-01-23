namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies ligature options for font rendering in WordprocessingML documents.
/// This enumeration provides values for different types and combinations of ligatures, supporting advanced typographic features and fine control over character joining in text content.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LigaturesKind
{
  /// <summary>
  /// No ligatures.
  /// </summary>
  None,

  /// <summary>
  /// Standard ligatures.
  /// </summary>
  Standard,

  /// <summary>
  /// Contextual ligatures.
  /// </summary>
  Contextual,

  /// <summary>
  /// Historical ligatures.
  /// </summary>
  Historical,

  /// <summary>
  /// Discretional ligatures.
  /// </summary>
  Discretional,

  /// <summary>
  /// Standard and contextual ligatures.
  /// </summary>
  StandardContextual,

  /// <summary>
  /// Standard and historical ligatures.
  /// </summary>
  StandardHistorical,

  /// <summary>
  /// Contextual and historical ligatures.
  /// </summary>
  ContextualHistorical,

  /// <summary>
  /// Standard and discretional ligatures.
  /// </summary>
  StandardDiscretional,

  /// <summary>
  /// Contextual and discretional ligatures.
  /// </summary>
  ContextualDiscretional,

  /// <summary>
  /// Historical and discretional ligatures.
  /// </summary>
  HistoricalDiscretional,

  /// <summary>
  /// Standard, contextual, and historical ligatures.
  /// </summary>
  StandardContextualHistorical,

  /// <summary>
  /// Standard, contextual, and discretional ligatures.
  /// </summary>
  StandardContextualDiscretional,

  /// <summary>
  /// Standard, historical, and discretional ligatures.
  /// </summary>
  StandardHistoricalDiscretional,

  /// <summary>
  /// Contextual, historical, and discretional ligatures.
  /// </summary>
  ContextualHistoricalDiscretional,

  /// <summary>
  /// All ligature types enabled.
  /// </summary>
  All
}