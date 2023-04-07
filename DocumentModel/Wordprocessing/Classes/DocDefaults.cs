namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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