using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumberingDefinitionsPart
/// </summary>
public class NumberingDefinitionsPart: ModelElement
{
  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Numbering? Numbering { get; set; }

  public string? RelationshipType { get; set; }
}