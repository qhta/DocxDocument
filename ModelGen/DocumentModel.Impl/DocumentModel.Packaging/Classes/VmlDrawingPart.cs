namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public class VmlDrawingPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, VmlDrawingPart
{
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public OpenXmlPartContainer? LegacyDiagramTextParts
  {
    get;
    set;
  }
  
}
