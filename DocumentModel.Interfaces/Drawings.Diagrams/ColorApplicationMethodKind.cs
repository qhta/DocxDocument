namespace DocumentModel.Drawings.Diagrams;

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