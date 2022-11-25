namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public interface IParagraphMarkRunPropertiesChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// author
  /// </summary>
  public System.String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public System.DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public DocumentModel.Wordprocessing.IPreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties { get ; set; }
  
}
