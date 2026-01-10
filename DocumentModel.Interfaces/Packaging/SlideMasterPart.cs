namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideMasterPart
/// </summary>
public interface SlideMasterPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ChartParts of the SlideMasterPart
  /// </summary>
  public ChartParts ChartParts { get; set; }

  /// <summary>
  ///   Gets the CustomXmlParts of the SlideMasterPart
  /// </summary>
  public CustomXmlParts CustomXmlParts { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the SlideMasterPart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the SlideMasterPart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the SlideMasterPart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the SlideMasterPart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the SlideMasterPart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataParts EmbeddedControlPersistenceBinaryDataParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the SlideMasterPart
  /// </summary>
  public EmbeddedControlPersistenceParts EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the SlideMasterPart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the SlideMasterPart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the SlideMasterPart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the SlideMasterPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the SlideMasterPart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }

  /// <summary>
  ///   Gets the SlideLayoutParts of the SlideMasterPart
  /// </summary>
  public SlideLayoutParts SlideLayoutParts { get; set; }
  /// <summary>
  ///   Gets the SlideParts of the SlideMasterPart
  /// </summary>
  public SlideParts SlideParts { get; set; }
  /// <summary>
  ///   Gets the UserDefinedTagsParts of the SlideMasterPart
  /// </summary>
  public UserDefinedTagsParts UserDefinedTagsParts { get; set; }
  /// <summary>
  ///   Gets the VmlDrawingParts of the SlideMasterPart
  /// </summary>
  public VmlDrawingParts VmlDrawingParts { get; set; }
}