namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Color IApplication Method Type
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
