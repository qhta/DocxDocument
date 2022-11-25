namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
public interface IParagraphPropertiesDefault // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle { get ; set; }
  
}
