namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Data Label Position
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DataLabelPositionKind
{
  /// <summary>
  ///   Best Fit.
  /// </summary>
  BestFit,

  /// <summary>
  ///   Bottom.
  /// </summary>
  Bottom,

  /// <summary>
  ///   Center.
  /// </summary>
  Center,

  /// <summary>
  ///   Inside Base.
  /// </summary>
  InsideBase,

  /// <summary>
  ///   Inside End.
  /// </summary>
  InsideEnd,

  /// <summary>
  ///   Left.
  /// </summary>
  Left,

  /// <summary>
  ///   Outside End.
  /// </summary>
  OutsideEnd,

  /// <summary>
  ///   Right.
  /// </summary>
  Right,

  /// <summary>
  ///   Top.
  /// </summary>
  Top
}