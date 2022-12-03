namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingCommentsIdsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.commentsIds+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2016/09/relationships/commentsIds")]
[PartConstraint(typeof(DocumentModel.Packaging.AlternativeFormatImportPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ChartPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ExtendedChartPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramColorsPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramDataPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramPersistLayoutPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramLayoutDefinitionPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramStylePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedControlPersistencePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedObjectPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedPackagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.Model3DReferenceRelationshipPart), false, true)]
[DataPartConstraint(typeof(DocumentModel.Packaging.VideoReferenceRelationship), false, true)]
public interface WordprocessingCommentsIdsPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public AlternativeFormatImportPart? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ChartPart? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsIds? CommentsIds { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
