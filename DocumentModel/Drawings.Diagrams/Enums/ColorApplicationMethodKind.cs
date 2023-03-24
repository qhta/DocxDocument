namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Color Application Method Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ColorApplicationMethodKind
{
  /// <summary>
  ///   Span.
  /// </summary>
  Span,

  /// <summary>
  ///   Cycle.
  /// </summary>
  Cycle,

  /// <summary>
  ///   Repeat.
  /// </summary>
  Repeat
}