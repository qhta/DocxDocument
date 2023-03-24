using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DiagramDataPart
/// </summary>
public class DiagramDataPart: ModelElement
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DataModelRoot? DataModelRoot { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public Collection<SlidePart>? SlideParts { get; set; }

  /// <summary>
  ///   Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public Collection<WorksheetPart>? WorksheetParts { get; set; }
}