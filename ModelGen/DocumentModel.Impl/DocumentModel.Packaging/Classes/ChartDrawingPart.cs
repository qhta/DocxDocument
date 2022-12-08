namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public class ChartDrawingPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartDrawingPart
{
  public new DocumentFormat.OpenXml.Packaging.ChartDrawingPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartDrawingPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get;
    set;
  }
  
  public override String? RelationshipType
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
