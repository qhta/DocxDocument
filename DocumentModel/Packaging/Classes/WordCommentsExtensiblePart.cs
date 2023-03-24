using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WordCommentsExtensiblePart
/// </summary>
public class WordCommentsExtensiblePart: ModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CommentsExtensible? CommentsExtensible { get; set; }

  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}