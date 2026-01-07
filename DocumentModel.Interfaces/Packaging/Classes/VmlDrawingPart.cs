namespace DocumentModel.Packaging;

/// <summary>
///   Defines the VmlDrawingPart
/// </summary>
public interface VmlDrawingPart: OpenXmlPart
{

  /// <summary>
  ///   Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public LegacyDiagramTextParts LegacyDiagramTextParts { get; set; }

}