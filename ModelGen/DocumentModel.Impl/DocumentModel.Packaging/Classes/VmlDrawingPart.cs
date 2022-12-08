namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public class VmlDrawingPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, VmlDrawingPart
{
  public new DocumentFormat.OpenXml.Packaging.VmlDrawingPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.VmlDrawingPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  public LegacyDiagramTextPart? LegacyDiagramTextParts
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
