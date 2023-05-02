namespace DocumentModel.Wordprocessing;

/// <summary>
///   Paragraph Properties.
/// </summary>
public class ParagraphProperties: ExtBaseParagraphProperties
{
  /// <summary>
  ///   Run Properties for the Paragraph Mark.
  /// </summary>
  public ParagraphMarkRunProperties? ParagraphMarkRunProperties { get; set; }

  /// <summary>
  ///   Section Properties.
  /// </summary>
  public SectionProperties? SectionProperties { get; set; }

  /// <summary>
  ///   ParagraphPropertiesChange.
  /// </summary>
  public ParagraphPropertiesChange? ParagraphPropertiesChange { get; set; }
}