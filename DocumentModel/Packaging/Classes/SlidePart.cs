namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlidePart
/// </summary>
public record SlidePart
{
  /// <summary>
  ///   Gets the ChartParts of the SlidePart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  /// <summary>
  ///   Gets the commentParts of the SlidePart
  /// </summary>
  public Collection<PowerPointCommentPart>? commentParts { get; set; }

  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the CustomXmlParts of the SlidePart
  /// </summary>
  public Collection<CustomXmlPart>? CustomXmlParts { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the SlidePart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the SlidePart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the SlidePart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the SlidePart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the SlidePart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the SlidePart
  /// </summary>
  public Collection<EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the SlidePart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the SlidePart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the SlidePart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the SlidePart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the SlidePart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets the SlideParts of the SlidePart
  /// </summary>
  public Collection<SlidePart>? SlideParts { get; set; }

  /// <summary>
  ///   Gets the UserDefinedTagsParts of the SlidePart
  /// </summary>
  public Collection<UserDefinedTagsPart>? UserDefinedTagsParts { get; set; }

  /// <summary>
  ///   Gets the VmlDrawingParts of the SlidePart
  /// </summary>
  public Collection<VmlDrawingPart>? VmlDrawingParts { get; set; }

  /// <summary>
  ///   Gets the WebExtensionParts of the SlidePart
  /// </summary>
  public Collection<WebExtensionPart>? WebExtensionParts { get; set; }
}