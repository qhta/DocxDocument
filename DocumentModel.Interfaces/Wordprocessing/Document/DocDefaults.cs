namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document Default Paragraph and Run Properties.
/// </summary>
public class DocDefaults: ModelElement
{
  /// <summary>
  ///   Default Run Properties.
  /// </summary>
  public DefaultRunProperties? RunPropertiesDefault { get; set; }
  /// <summary>
  ///   Default Paragraph Properties.
  /// </summary>
  public DefaultParagraphProperties? ParagraphPropertiesDefault { get; set; }
}