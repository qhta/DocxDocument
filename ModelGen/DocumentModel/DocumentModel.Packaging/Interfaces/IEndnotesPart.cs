namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EndnotesPart
/// </summary>
public interface IEndnotesPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the EndnotesPart
  /// </summary>
  public IAlternativeFormatImportPart? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the EndnotesPart
  /// </summary>
  public IChartPart? ChartParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the EndnotesPart
  /// </summary>
  public IDiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the EndnotesPart
  /// </summary>
  public IDiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the EndnotesPart
  /// </summary>
  public IDiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the EndnotesPart
  /// </summary>
  public IDiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the EndnotesPart
  /// </summary>
  public IDiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the EndnotesPart
  /// </summary>
  public IEmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the EndnotesPart
  /// </summary>
  public IEmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the EndnotesPart
  /// </summary>
  public IEmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.IEndnotes? Endnotes { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the EndnotesPart
  /// </summary>
  public IExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the EndnotesPart
  /// </summary>
  public IImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the EndnotesPart
  /// </summary>
  public IModel3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
