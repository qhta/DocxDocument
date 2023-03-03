namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the QuartileMethod enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum QuartileMethod
{
  /// <summary>
  ///   inclusive.
  /// </summary>
  Inclusive,

  /// <summary>
  ///   exclusive.
  /// </summary>
  Exclusive
}