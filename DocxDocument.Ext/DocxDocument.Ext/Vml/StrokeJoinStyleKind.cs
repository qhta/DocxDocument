namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Line Join Type
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeJoinStyleKind
{
  /// <summary>
  ///   Round Joint.
  /// </summary>
  Round,

  /// <summary>
  ///   Bevel Joint.
  /// </summary>
  Bevel,

  /// <summary>
  ///   Miter Joint.
  /// </summary>
  Miter
}