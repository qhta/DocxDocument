namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlidePart
/// </summary>
public interface SlidePart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ChartParts of the SlidePart
  /// </summary>
  public ChartParts ChartParts { get; set; }
  /// <summary>
  ///   Gets the commentParts of the SlidePart
  /// </summary>
  public CommentParts CommentParts { get; set; }
  /// <summary>
  ///   Gets the CustomXmlParts of the SlidePart
  /// </summary>
  public CustomXmlParts CustomXmlParts { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the SlidePart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the SlidePart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the SlidePart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the SlidePart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the SlidePart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataParts EmbeddedControlPersistenceBinaryDataParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the SlidePart
  /// </summary>
  public EmbeddedControlPersistenceParts EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the SlidePart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the SlidePart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the SlidePart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the SlidePart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the SlidePart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }
  /// <summary>
  ///   Gets the SlideParts of the SlidePart
  /// </summary>
  public SlideParts SlideParts { get; set; }
  /// <summary>
  ///   Gets the UserDefinedTagsParts of the SlidePart
  /// </summary>
  public UserDefinedTagsParts UserDefinedTagsParts { get; set; }
  /// <summary>
  ///   Gets the VmlDrawingParts of the SlidePart
  /// </summary>
  public VmlDrawingParts VmlDrawingParts { get; set; }
  /// <summary>
  ///   Gets the WebExtensionParts of the SlidePart
  /// </summary>
  public WebExtensionParts WebExtensionParts { get; set; }
}