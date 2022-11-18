namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphPropertiesChange Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraphPropertiesExtended))]
public interface IParagraphPropertiesChange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Previous Paragraph Properties.
  /// </summary>
  public IParagraphPropertiesExtended? ParagraphPropertiesExtended { get ; set; }
  
}
