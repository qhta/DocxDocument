namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideLayoutPart
/// </summary>
public interface SlideLayoutPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ChartParts of the SlideLayoutPart
  /// </summary>
  public ChartParts ChartParts { get; set; }
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the CustomXmlParts of the SlideLayoutPart
  /// </summary>
  public CustomXmlParts CustomXmlParts { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the SlideLayoutPart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the SlideLayoutPart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the SlideLayoutPart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the SlideLayoutPart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the SlideLayoutPart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideLayoutPart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataParts EmbeddedControlPersistenceBinaryDataParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the SlideLayoutPart
  /// </summary>
  public EmbeddedControlPersistenceParts EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the SlideLayoutPart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the SlideLayoutPart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the SlideLayoutPart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the SlideLayoutPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the SlideLayoutPart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets the SlideParts of the SlideLayoutPart
  /// </summary>
  public SlideParts SlideParts { get; set; }
  /// <summary>
  ///   Gets the UserDefinedTagsParts of the SlideLayoutPart
  /// </summary>
  public UserDefinedTagsParts UserDefinedTagsParts { get; set; }
  /// <summary>
  ///   Gets the VmlDrawingParts of the SlideLayoutPart
  /// </summary>
  public VmlDrawingParts VmlDrawingParts { get; set; }
}