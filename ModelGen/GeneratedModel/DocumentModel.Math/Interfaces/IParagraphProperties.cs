namespace DocumentModel.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IJustification))]
public interface IParagraphProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Math.IJustification? Justification { get ; set; }
  
}
