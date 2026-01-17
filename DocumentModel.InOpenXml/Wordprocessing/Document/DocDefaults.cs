namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the default paragraph and run properties for a WordprocessingML document.
///   This interface provides properties for specifying the default character-level and paragraph-level formatting applied to all runs and paragraphs in the document unless overridden by more specific formatting.
/// </summary>
public class DocDefaults: ModelElement<DXW.DocDefaults>
{
  /// <summary>
  ///   Default run properties, specifying the default character-level formatting for text runs.
  /// </summary>
  public DefaultRunProperties? RunPropertiesDefault { get; set; }

  /// <summary>
  ///   Default paragraph properties, specifying the default paragraph-level formatting for paragraphs.
  /// </summary>
  public DefaultParagraphProperties? ParagraphPropertiesDefault { get; set; }
}