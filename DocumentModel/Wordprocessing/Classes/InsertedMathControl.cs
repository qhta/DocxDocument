namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the InsertedMathControl Class.
/// </summary>
public class InsertedMathControl: ModelElement
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