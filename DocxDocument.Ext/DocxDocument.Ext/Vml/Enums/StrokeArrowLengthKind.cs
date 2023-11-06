namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Stroke Arrowhead Length
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum StrokeArrowLengthKind
{
  /// <summary>
  ///   Short Arrowhead.
  /// </summary>
  Short,

  /// <summary>
  ///   Medium Arrowhead.
  /// </summary>
  Medium,

  /// <summary>
  ///   Long Arrowhead.
  /// </summary>
  Long
}