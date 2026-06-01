namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Stroke ILine IStyle
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeLineStyleKind
{
  /// <summary>
  ///   Single ILine.
  /// </summary>
  Single,

  /// <summary>
  ///   Two Thin ILines.
  /// </summary>
  ThinThin,

  /// <summary>
  ///   Thin ILine Outside Thick ILine.
  /// </summary>
  ThinThick,

  /// <summary>
  ///   Thick ILine Outside Thin ILine.
  /// </summary>
  ThickThin,

  /// <summary>
  ///   Thck ILine Between Thin ILines.
  /// </summary>
  ThickBetweenThin
}
