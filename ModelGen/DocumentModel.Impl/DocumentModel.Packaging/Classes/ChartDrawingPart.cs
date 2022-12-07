namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public class ChartDrawingPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, ChartDrawingPart
{
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.UserShapes? UserShapes
  {
    get;
    set;
  }
  
}
