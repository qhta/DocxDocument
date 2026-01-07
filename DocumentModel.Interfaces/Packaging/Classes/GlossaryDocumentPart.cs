using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the GlossaryDocumentPart
/// </summary>
public interface GlossaryDocumentPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public AlternativeFormatImportParts AlternativeFormatImportParts { get; set; }
  /// <summary>
  ///   Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public ChartParts ChartParts { get; set; }
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public EmbeddedControlPersistenceParts EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public FooterParts FooterParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public GlossaryDocument? GlossaryDocument { get; set; }
  /// <summary>
  ///   Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public HeaderParts HeaderParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public WordprocessingPrinterSettingsParts WordprocessingPrinterSettingsParts { get; set; }
}