namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the InsertedMathControl Class.
/// </summary>
public record InsertedMathControl
{
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

  public RunProperties? RunProperties { get; set; }

  public DeletedMathControl? DeletedMathControl { get; set; }
}