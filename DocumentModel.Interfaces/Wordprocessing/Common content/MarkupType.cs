namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public interface MarkupType: ICommonContent
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? Id { get; set; }
}