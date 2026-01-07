namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NotesMasterPart
/// </summary>
public interface NotesMasterPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ChartParts of the NotesMasterPart
  /// </summary>
  public ChartParts ChartParts { get; set; }

  /// <summary>
  ///   Gets the CustomXmlParts of the NotesMasterPart
  /// </summary>
  public CustomXmlParts CustomXmlParts { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the NotesMasterPart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the NotesMasterPart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the NotesMasterPart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the NotesMasterPart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the NotesMasterPart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesMasterPart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataParts EmbeddedControlPersistenceBinaryDataParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the NotesMasterPart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the NotesMasterPart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the NotesMasterPart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the NotesMasterPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the NotesMasterPart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }

  /// <summary>
  ///   Gets the UserDefinedTagsParts of the NotesMasterPart
  /// </summary>
  public UserDefinedTagsParts UserDefinedTagsParts { get; set; }
  /// <summary>
  ///   Gets the VmlDrawingParts of the NotesMasterPart
  /// </summary>
  public VmlDrawingParts VmlDrawingParts { get; set; }
}