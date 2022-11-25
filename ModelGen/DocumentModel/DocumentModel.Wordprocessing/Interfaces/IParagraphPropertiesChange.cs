namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphPropertiesChange Class.
/// </summary>
public interface IParagraphPropertiesChange // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// Previous Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IParagraphPropertiesExtended? ParagraphPropertiesExtended { get ; set; }
  
}
