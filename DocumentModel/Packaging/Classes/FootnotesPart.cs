using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FootnotesPart
/// </summary>
public class FootnotesPart: ModelElement
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the FootnotesPart
  /// </summary>
  public Collection<AlternativeFormatImportPart>? AlternativeFormatImportParts { get; set; }

  /// <summary>
  ///   Gets the ChartParts of the FootnotesPart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the FootnotesPart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the FootnotesPart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the FootnotesPart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the FootnotesPart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the FootnotesPart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the FootnotesPart
  /// </summary>
  public Collection<EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the FootnotesPart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the FootnotesPart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the FootnotesPart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Footnotes? Footnotes { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the FootnotesPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the FootnotesPart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }

  public string? RelationshipType { get; set; }
}