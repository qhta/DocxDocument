namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document Default Paragraph and Run Properties.
/// </summary>
public interface DocDefaults: IModelElement
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