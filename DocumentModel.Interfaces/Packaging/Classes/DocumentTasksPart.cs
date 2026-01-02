namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DocumentTasksPart
/// </summary>
public class DocumentTasksPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Tasks? Tasks { get; set; }
}