namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideMasterPart
/// </summary>
public class SlideMasterPart: ModelElement
{
  /// <summary>
  ///   Gets the ChartParts of the SlideMasterPart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the CustomXmlParts of the SlideMasterPart
  /// </summary>
  public Collection<CustomXmlPart>? CustomXmlParts { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the SlideMasterPart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the SlideMasterPart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the SlideMasterPart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the SlideMasterPart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the SlideMasterPart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the SlideMasterPart
  /// </summary>
  public Collection<EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the SlideMasterPart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the SlideMasterPart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the SlideMasterPart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the SlideMasterPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the SlideMasterPart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets the SlideLayoutParts of the SlideMasterPart
  /// </summary>
  public Collection<SlideLayoutPart>? SlideLayoutParts { get; set; }

  /// <summary>
  ///   Gets the SlideParts of the SlideMasterPart
  /// </summary>
  public Collection<SlidePart>? SlideParts { get; set; }

  /// <summary>
  ///   Gets the UserDefinedTagsParts of the SlideMasterPart
  /// </summary>
  public Collection<UserDefinedTagsPart>? UserDefinedTagsParts { get; set; }

  /// <summary>
  ///   Gets the VmlDrawingParts of the SlideMasterPart
  /// </summary>
  public Collection<VmlDrawingPart>? VmlDrawingParts { get; set; }
}