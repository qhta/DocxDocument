namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VmlDrawingPart
/// </summary>
public class VmlDrawingPart: ModelElement
{
  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public Collection<LegacyDiagramTextPart>? LegacyDiagramTextParts { get; set; }

  public string? RelationshipType { get; set; }
}