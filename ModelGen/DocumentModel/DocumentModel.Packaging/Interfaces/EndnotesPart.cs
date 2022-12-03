namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EndnotesPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes")]
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
public interface EndnotesPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the EndnotesPart
  /// </summary>
  public AlternativeFormatImportPart? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the EndnotesPart
  /// </summary>
  public ChartPart? ChartParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the EndnotesPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the EndnotesPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the EndnotesPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the EndnotesPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the EndnotesPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the EndnotesPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the EndnotesPart
  /// </summary>
  public EmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the EndnotesPart
  /// </summary>
  public EmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Endnotes? Endnotes { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the EndnotesPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the EndnotesPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the EndnotesPart
  /// </summary>
  public Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
