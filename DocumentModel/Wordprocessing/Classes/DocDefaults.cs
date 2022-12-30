namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
public partial class DocDefaults
{
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesDefault? RunPropertiesDefault { get; set; }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphPropertiesDefault? ParagraphPropertiesDefault { get; set; }
  
}
