namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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