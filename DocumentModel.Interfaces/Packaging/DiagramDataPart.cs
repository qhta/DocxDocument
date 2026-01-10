using DocumentModel.Drawings.Diagrams;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DiagramDataPart
/// </summary>
public interface DiagramDataPart: OpenXmlPart
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DataModelRoot? DataModelRoot { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public SlideParts SlideParts { get; set; }
  /// <summary>
  ///   Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public WorksheetParts WorksheetParts { get; set; }
}
