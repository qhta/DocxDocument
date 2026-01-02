namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NotesSlidePart
/// </summary>
public class NotesSlidePart: ModelElement
{
  /// <summary>
  ///   Gets the ChartParts of the NotesSlidePart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the CustomXmlParts of the NotesSlidePart
  /// </summary>
  public Collection<CustomXmlPart>? CustomXmlParts { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the NotesSlidePart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the NotesSlidePart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the NotesSlidePart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the NotesSlidePart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the NotesSlidePart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesSlidePart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the NotesSlidePart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the NotesSlidePart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the NotesSlidePart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the NotesSlidePart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the NotesSlidePart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets the UserDefinedTagsParts of the NotesSlidePart
  /// </summary>
  public Collection<UserDefinedTagsPart>? UserDefinedTagsParts { get; set; }
  /// <summary>
  ///   Gets the VmlDrawingParts of the NotesSlidePart
  /// </summary>
  public Collection<VmlDrawingPart>? VmlDrawingParts { get; set; }
}