namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NotesMasterPart
/// </summary>
public record NotesMasterPart
{
  /// <summary>
  ///   Gets the ChartParts of the NotesMasterPart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the CustomXmlParts of the NotesMasterPart
  /// </summary>
  public Collection<CustomXmlPart>? CustomXmlParts { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the NotesMasterPart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the NotesMasterPart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the NotesMasterPart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the NotesMasterPart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the NotesMasterPart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesMasterPart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the NotesMasterPart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the NotesMasterPart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the NotesMasterPart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the NotesMasterPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the NotesMasterPart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets the UserDefinedTagsParts of the NotesMasterPart
  /// </summary>
  public Collection<UserDefinedTagsPart>? UserDefinedTagsParts { get; set; }

  /// <summary>
  ///   Gets the VmlDrawingParts of the NotesMasterPart
  /// </summary>
  public Collection<VmlDrawingPart>? VmlDrawingParts { get; set; }
}