namespace DocumentModel.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public partial interface ParagraphProperties
{
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Math.JustificationKind? Justification { get; set; }
  
}
