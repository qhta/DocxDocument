namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Previous Paragraph Numbering Properties.
/// </summary>
public class NumberingChange: ModelElement
{
  /// <summary>
  ///   original
  /// </summary>
  public string? Original { get; set; }

  /// <summary>
  ///   author
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? Id { get; set; }
}