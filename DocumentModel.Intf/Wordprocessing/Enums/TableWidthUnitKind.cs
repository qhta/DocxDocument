namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableWidthUnitValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableWidthUnitType
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
  Twips,

  /// <summary>
  ///   Automatically Determined Width.
  /// </summary>
  Auto
}