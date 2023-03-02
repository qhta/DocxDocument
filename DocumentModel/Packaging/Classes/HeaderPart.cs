using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the HeaderPart
/// </summary>
public record HeaderPart
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the HeaderPart
  /// </summary>
  public Collection<AlternativeFormatImportPart>? AlternativeFormatImportParts { get; set; }

  /// <summary>
  ///   Gets the ChartParts of the HeaderPart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the HeaderPart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the HeaderPart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the HeaderPart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the HeaderPart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the HeaderPart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the HeaderPart
  /// </summary>
  public Collection<EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the HeaderPart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the HeaderPart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the HeaderPart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Header? Header { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the HeaderPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the HeaderPart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }

  public String? RelationshipType { get; set; }
}