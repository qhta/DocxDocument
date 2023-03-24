namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Stroke Arrowhead Width
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeArrowWidthKind
{
  /// <summary>
  ///   Narrow Arrowhead.
  /// </summary>
  Narrow,

  /// <summary>
  ///   Medium Arrowhead.
  /// </summary>
  Medium,

  /// <summary>
  ///   Wide Arrowhead.
  /// </summary>
  Wide
}