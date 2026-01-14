namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies how the width of a table, row, or cell is determined.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WidthRuleKind
{
  /// <summary>Width adjusts automatically based on content</summary>
  Auto,

  /// <summary>Width is specified as a percentage of available space</summary>
  Percentage,

  /// <summary>Width is specified as an absolute value</summary>
  Absolute,

  /// <summary>Width is specified in fiftieths of a percent</summary>
  Pct,

  /// <summary>Width is specified in twentieths of a point (twips)</summary>
  Dxa,

  /// <summary>Width is specified as nil (no width)</summary>
  Nil
}