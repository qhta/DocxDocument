using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GlossaryDocumentPart
/// </summary>
public class GlossaryDocumentPart: ModelElement
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<AlternativeFormatImportPart>? AlternativeFormatImportParts { get; set; }

  /// <summary>
  ///   Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<FooterPart>? FooterParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public GlossaryDocument? GlossaryDocument { get; set; }

  /// <summary>
  ///   Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<HeaderPart>? HeaderParts { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }

  public string? RelationshipType { get; set; }

  /// <summary>
  ///   Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts { get; set; }
}