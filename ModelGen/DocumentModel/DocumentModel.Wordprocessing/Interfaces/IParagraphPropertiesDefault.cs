namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraphPropertiesBaseStyle))]
public interface IParagraphPropertiesDefault // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public IParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle { get ; set; }
  
}
