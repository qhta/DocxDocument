namespace DocumentModel.Packaging;

/// <summary>
/// Defines the MainDocumentPart
/// </summary>
public interface IMainDocumentPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public IAlternativeFormatImportPart? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public IChartPart? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public ICustomXmlPart? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public IDiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public IDiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public IDiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public IDiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public IDiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.IDocument? Document { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public IEmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public IEmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public IEmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public IExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public IFooterPart? FooterParts { get ; set; }
  
  /// <summary>
  /// Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public IHeaderPart? HeaderParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public IImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public IModel3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public IWordprocessingPrinterSettingsPart? WordprocessingPrinterSettingsParts { get ; set; }
  
}
