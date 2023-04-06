namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ParagraphPropertiesChange Class.
/// </summary>
public class ParagraphPropertiesChange: ModelElement
{
  /// <summary>
  ///   Author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   Sate
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Previous Paragraph Properties.
  /// </summary>
  public PreviousParagraphProperties? PreviousParagraphProperties { get; set; }
}