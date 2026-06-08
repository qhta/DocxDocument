namespace DocumentModel.Wordprocessing;

/// <summary>
///   IParagraph Properties.
/// </summary>
public class ParagraphProperties: ExtBaseParagraphProperties
{
  /// <summary>
  ///   Run Properties for the IParagraph Mark.
  /// </summary>
  public ParagraphMarkRunProperties? ParagraphMarkRunProperties { get; set; }

  /// <summary>
  ///   ISection Properties.
  /// </summary>
  public SectionProperties? SectionProperties { get; set; }

  /// <summary>
  ///   ParagraphPropertiesChange.
  /// </summary>
  public ParagraphPropertiesChange? ParagraphPropertiesChange { get; set; }
}
