namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IDocument Default IParagraph and Run Properties.
/// </summary>
public class DocDefaults: ModelElement
{
  /// <summary>
  ///   Default Run Properties.
  /// </summary>
  public DefaultRunProperties? RunPropertiesDefault { get; set; }

  /// <summary>
  ///   Default IParagraph Properties.
  /// </summary>
  public DefaultParagraphProperties? ParagraphPropertiesDefault { get; set; }
}
