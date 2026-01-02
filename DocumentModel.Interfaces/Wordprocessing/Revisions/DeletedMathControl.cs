namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DeletedMathControl Class.
/// </summary>
public class DeletedMathControl: ModelElement
{
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
  public RunProperties? RunProperties { get; set; }
}