namespace DocumentModel.Math;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public interface IParagraph // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Office Math Paragraph Properties.
  /// </summary>
  public IParagraphProperties? ParagraphProperties { get ; set; }
  
}
