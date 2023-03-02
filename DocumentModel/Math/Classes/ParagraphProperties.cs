namespace DocumentModel.Math;

/// <summary>
///   Office Math Paragraph Properties.
/// </summary>
public record ParagraphProperties
{
  /// <summary>
  ///   Justification.
  /// </summary>
  public JustificationKind? Justification { get; set; }
}