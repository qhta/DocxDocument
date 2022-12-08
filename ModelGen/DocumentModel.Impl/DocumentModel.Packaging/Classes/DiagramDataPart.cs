namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public class DiagramDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DiagramDataPart
{
  public new DocumentFormat.OpenXml.Packaging.DiagramDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DiagramDataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.DataModelRoot? DataModelRoot
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
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
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public SlidePart? SlideParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public WorksheetPart? WorksheetParts
  {
    get;
    set;
  }
  
}
