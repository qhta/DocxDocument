namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public record MarkupType: CommonElement
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
}