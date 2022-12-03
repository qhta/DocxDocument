namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideMasterPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster")]
[PartConstraint(typeof(DocumentModel.Packaging.CustomXmlPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ChartPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ExtendedChartPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramColorsPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramDataPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramPersistLayoutPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramLayoutDefinitionPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramStylePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedObjectPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedPackagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.VmlDrawingPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.Model3DReferenceRelationshipPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ThemePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.SlidePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.SlideLayoutPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedControlPersistencePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.UserDefinedTagsPart), false, true)]
[DataPartConstraint(typeof(DocumentModel.Packaging.AudioReferenceRelationship), false, true)]
[DataPartConstraint(typeof(DocumentModel.Packaging.VideoReferenceRelationship), false, true)]
[DataPartConstraint(typeof(DocumentModel.Packaging.MediaReferenceRelationship), false, true)]
public interface SlideMasterPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets the ChartParts of the SlideMasterPart
  /// </summary>
  public ChartPart? ChartParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlideMasterPart
  /// </summary>
  public CustomXmlPart? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlideMasterPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlideMasterPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlideMasterPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlideMasterPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlideMasterPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlideMasterPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlideMasterPart
  /// </summary>
  public EmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlideMasterPart
  /// </summary>
  public EmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlideMasterPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the SlideMasterPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlideMasterPart
  /// </summary>
  public Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlideLayoutParts of the SlideMasterPart
  /// </summary>
  public SlideLayoutPart? SlideLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.SlideMaster? SlideMaster { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the SlideMasterPart
  /// </summary>
  public SlidePart? SlideParts { get ; set; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlideMasterPart
  /// </summary>
  public UserDefinedTagsPart? UserDefinedTagsParts { get ; set; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlideMasterPart
  /// </summary>
  public VmlDrawingPart? VmlDrawingParts { get ; set; }
  
}
