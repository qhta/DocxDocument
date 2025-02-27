namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Stroke Line Style
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeLineStyleKind
{
  /// <summary>
  ///   Single Line.
  /// </summary>
  Single,

  /// <summary>
  ///   Two Thin Lines.
  /// </summary>
  ThinThin,

  /// <summary>
  ///   Thin Line Outside Thick Line.
  /// </summary>
  ThinThick,

  /// <summary>
  ///   Thick Line Outside Thin Line.
  /// </summary>
  ThickThin,

  /// <summary>
  ///   Thck Line Between Thin Lines.
  /// </summary>
  ThickBetweenThin
}