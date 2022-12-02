namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
public interface IDocDefaults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  public IRunPropertiesDefault? RunPropertiesDefault { get ; set; }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  public IParagraphPropertiesDefault? ParagraphPropertiesDefault { get ; set; }
  
}
