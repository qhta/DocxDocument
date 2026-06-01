namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  ///   Width Iin Fiftieths of a Percent.
  /// </summary>
  Pct,

  /// <summary>
  ///   Width Iin Twentieths of a IPoint.
  /// </summary>
  Twips,

  /// <summary>
  ///   Automatically Determined Width.
  /// </summary>
  Auto
}
