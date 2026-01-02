using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordprocessingPeoplePart
/// </summary>
public class WordprocessingPeoplePart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public People? People { get; set; }
  public string? RelationshipType { get; set; }
}