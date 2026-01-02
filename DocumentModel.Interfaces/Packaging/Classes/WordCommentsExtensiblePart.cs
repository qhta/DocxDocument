using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordCommentsExtensiblePart
/// </summary>
public class WordCommentsExtensiblePart: ModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CommentsExtensible? CommentsExtensible { get; set; }
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}