using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NumberingDefinitionsPart
/// </summary>
public record NumberingDefinitionsPart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Numbering? Numbering { get; set; }

  public String? RelationshipType { get; set; }
}