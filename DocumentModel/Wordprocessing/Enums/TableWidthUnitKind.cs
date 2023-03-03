namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableWidthUnitValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableWidthUnitKind
{
  /// <summary>
  ///   No Width.
  /// </summary>
  Nil,

  /// <summary>
  ///   Width in Fiftieths of a Percent.
  /// </summary>
  Pct,

  /// <summary>
  ///   Width in Twentieths of a Point.
  /// </summary>
  Dxa,

  /// <summary>
  ///   Automatically Determined Width.
  /// </summary>
  Auto
}