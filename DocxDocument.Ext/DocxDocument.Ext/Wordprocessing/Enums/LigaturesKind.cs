namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LigaturesValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum LigaturesKind
{
  /// <summary>
  ///   none.
  /// </summary>
  None,

  /// <summary>
  ///   standard.
  /// </summary>
  Standard,

  /// <summary>
  ///   contextual.
  /// </summary>
  Contextual,

  /// <summary>
  ///   historical.
  /// </summary>
  Historical,

  /// <summary>
  ///   discretional.
  /// </summary>
  Discretional,

  /// <summary>
  ///   standardContextual.
  /// </summary>
  StandardContextual,

  /// <summary>
  ///   standardHistorical.
  /// </summary>
  StandardHistorical,

  /// <summary>
  ///   contextualHistorical.
  /// </summary>
  ContextualHistorical,

  /// <summary>
  ///   standardDiscretional.
  /// </summary>
  StandardDiscretional,

  /// <summary>
  ///   contextualDiscretional.
  /// </summary>
  ContextualDiscretional,

  /// <summary>
  ///   historicalDiscretional.
  /// </summary>
  HistoricalDiscretional,

  /// <summary>
  ///   standardContextualHistorical.
  /// </summary>
  StandardContextualHistorical,

  /// <summary>
  ///   standardContextualDiscretional.
  /// </summary>
  StandardContextualDiscretional,

  /// <summary>
  ///   standardHistoricalDiscretional.
  /// </summary>
  StandardHistoricalDiscretional,

  /// <summary>
  ///   contextualHistoricalDiscretional.
  /// </summary>
  ContextualHistoricalDiscretional,

  /// <summary>
  ///   all.
  /// </summary>
  All
}