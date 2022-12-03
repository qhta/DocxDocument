namespace DocumentModel.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public interface ParagraphProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Justification.
  /// </summary>
  public JustificationKind? Justification { get ; set; }
  
}
