namespace DocumentModel.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public interface IParagraphProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Justification.
  /// </summary>
  public JustificationKind? Justification { get ; set; }
  
}
