using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the MainDocumentPart
/// </summary>
public record MainDocumentPart
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public Collection<AlternativeFormatImportPart>? AlternativeFormatImportParts { get; set; }

  /// <summary>
  ///   Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  /// <summary>
  ///   Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public Collection<CustomXmlPart>? CustomXmlParts { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Document? Document { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public Collection<EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public Collection<FooterPart>? FooterParts { get; set; }

  /// <summary>
  ///   Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public Collection<HeaderPart>? HeaderParts { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public Collection<WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts { get; set; }
}