namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public class DiagramDataPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, DiagramDataPart
{
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
  public OpenXmlPartContainer? ImageParts
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
