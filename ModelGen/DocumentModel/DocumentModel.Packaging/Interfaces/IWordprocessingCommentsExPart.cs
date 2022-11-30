namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingCommentsExPart
/// </summary>
public interface IWordprocessingCommentsExPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IAlternativeFormatImportPart? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IChartPart? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Office2013.Word.ICommentsEx? CommentsEx { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsExPart
  /// </summary>
  public DocumentModel.Packaging.IModel3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
