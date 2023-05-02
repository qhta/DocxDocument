namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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