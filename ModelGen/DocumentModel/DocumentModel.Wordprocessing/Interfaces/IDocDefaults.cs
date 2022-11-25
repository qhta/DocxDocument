namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
public interface IDocDefaults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunPropertiesDefault? RunPropertiesDefault { get ; set; }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IParagraphPropertiesDefault? ParagraphPropertiesDefault { get ; set; }
  
}
