using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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