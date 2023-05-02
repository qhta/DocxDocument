using DocumentModel.Drawings;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ThemePart
/// </summary>
public class ThemePart: ModelElement
{
  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the ThemePart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public string? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Theme? Theme { get; set; }
}