namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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