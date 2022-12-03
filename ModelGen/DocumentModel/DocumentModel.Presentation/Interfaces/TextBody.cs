namespace DocumentModel.Presentation;

/// <summary>
/// Shape Text Body.
/// </summary>
public interface TextBody // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public DocumentModel.Drawings.ListStyle? ListStyle { get ; set; }
  
  public Collection<DocumentModel.Drawings.Paragraph>? Paragraphs { get ; set; }
  
}
