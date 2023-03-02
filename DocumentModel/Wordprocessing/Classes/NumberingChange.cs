namespace DocumentModel.Wordprocessing;

/// <summary>
///   Previous Paragraph Numbering Properties.
/// </summary>
public record NumberingChange
{
  /// <summary>
  ///   original
  /// </summary>
  public String? Original { get; set; }

  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
}