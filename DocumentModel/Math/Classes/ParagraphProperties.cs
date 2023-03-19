namespace DocumentModel.Math;

/// <summary>
///   Office Math Paragraph Properties.
/// </summary>
public class ParagraphProperties: ModelElement
{
  /// <summary>
  ///   Justification.
  /// </summary>
  public JustificationKind? Justification { get; set; }
}