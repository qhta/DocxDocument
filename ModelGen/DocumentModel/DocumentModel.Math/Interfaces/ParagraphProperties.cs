namespace DocumentModel.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public interface ParagraphProperties
{
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Math.JustificationKind? Justification { get ; set; }
  
}
