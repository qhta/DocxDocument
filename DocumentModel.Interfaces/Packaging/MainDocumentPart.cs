using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the MainDocumentPart
/// </summary>
public interface MainDocumentPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public AlternativeFormatImportParts AlternativeFormatImportParts { get; set; }
  /// <summary>
  ///   Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public ChartParts ChartParts { get; set; }
  /// <summary>
  ///   Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public CustomXmlParts CustomXmlParts { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Document? Document { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public EmbeddedControlPersistenceParts EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public FooterParts FooterParts { get; set; }
  /// <summary>
  ///   Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public HeaderParts HeaderParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }

  /// <summary>
  ///   Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public WordprocessingPrinterSettingsParts WordprocessingPrinterSettingsParts { get; set; }
}