namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MathControlMoveType Class.
/// </summary>
public class MathControlMoveType: ModelElement
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
}