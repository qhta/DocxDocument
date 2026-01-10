using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the FooterPart
/// </summary>
public interface FooterPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the FooterPart
  /// </summary>
  public AlternativeFormatImportParts AlternativeFormatImportParts { get; set; }
  /// <summary>
  ///   Gets the ChartParts of the FooterPart
  /// </summary>
  public ChartParts ChartParts { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the FooterPart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the FooterPart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the FooterPart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the FooterPart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the FooterPart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the FooterPart
  /// </summary>
  public EmbeddedControlPersistenceParts EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the FooterPart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the FooterPart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the FooterPart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Footer? Footer { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the FooterPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the FooterPart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }

}