namespace DocumentModel.Packaging;

/// <summary>
///   Defines the VmlDrawingPart
/// </summary>
public class VmlDrawingPart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public Collection<LegacyDiagramTextPart>? LegacyDiagramTextParts { get; set; }

  public String? RelationshipType { get; set; }
}