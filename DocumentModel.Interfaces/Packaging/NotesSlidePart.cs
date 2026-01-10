namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NotesSlidePart
/// </summary>
public interface NotesSlidePart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ChartParts of the NotesSlidePart
  /// </summary>
  public ChartParts ChartParts { get; set; }

  /// <summary>
  ///   Gets the CustomXmlParts of the NotesSlidePart
  /// </summary>
  public CustomXmlParts CustomXmlParts { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the NotesSlidePart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the NotesSlidePart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the NotesSlidePart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the NotesSlidePart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the NotesSlidePart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesSlidePart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataParts EmbeddedControlPersistenceBinaryDataParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the NotesSlidePart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the NotesSlidePart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the NotesSlidePart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the NotesSlidePart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the NotesSlidePart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }

  /// <summary>
  ///   Gets the UserDefinedTagsParts of the NotesSlidePart
  /// </summary>
  public UserDefinedTagsParts UserDefinedTagsParts { get; set; }
  /// <summary>
  ///   Gets the VmlDrawingParts of the NotesSlidePart
  /// </summary>
  public VmlDrawingParts VmlDrawingParts { get; set; }
}