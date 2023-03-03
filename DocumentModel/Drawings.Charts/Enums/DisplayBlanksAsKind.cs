namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Display Blanks As
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DisplayBlanksAsKind
{
  /// <summary>
  ///   Span.
  /// </summary>
  Span,

  /// <summary>
  ///   Gap.
  /// </summary>
  Gap,

  /// <summary>
  ///   Zero.
  /// </summary>
  Zero
}