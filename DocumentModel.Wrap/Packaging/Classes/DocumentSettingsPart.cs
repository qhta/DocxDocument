using DocumentModel;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DocumentSettingsPart
/// </summary>
public class DocumentSettingsPart: ModelElement
{
  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public string? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentSettings? Settings { get; set; }
}