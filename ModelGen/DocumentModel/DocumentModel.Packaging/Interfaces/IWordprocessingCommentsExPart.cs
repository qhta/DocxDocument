namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingCommentsExPart
/// </summary>
public interface IWordprocessingCommentsExPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsExPart
  /// </summary>
  public IAlternativeFormatImportPart? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the WordprocessingCommentsExPart
  /// </summary>
  public IChartPart? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.ICommentsEx? CommentsEx { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the WordprocessingCommentsExPart
  /// </summary>
  public IDiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the WordprocessingCommentsExPart
  /// </summary>
  public IDiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsExPart
  /// </summary>
  public IDiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsExPart
  /// </summary>
  public IDiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the WordprocessingCommentsExPart
  /// </summary>
  public IDiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsExPart
  /// </summary>
  public IEmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WordprocessingCommentsExPart
  /// </summary>
  public IEmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WordprocessingCommentsExPart
  /// </summary>
  public IEmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the WordprocessingCommentsExPart
  /// </summary>
  public IExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WordprocessingCommentsExPart
  /// </summary>
  public IImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsExPart
  /// </summary>
  public IModel3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
