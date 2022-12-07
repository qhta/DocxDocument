namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public interface VmlDrawingPart
{
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public OpenXmlPartContainer? LegacyDiagramTextParts { get ; set; }
  
}
