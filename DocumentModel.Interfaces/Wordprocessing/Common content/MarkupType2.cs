namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public class MarkupType2: ModelElement, IRangeMarkupElement, ICommonContent
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? Id { get; set; }
}