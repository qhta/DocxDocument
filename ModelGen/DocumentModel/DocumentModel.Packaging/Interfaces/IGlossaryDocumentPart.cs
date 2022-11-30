namespace DocumentModel.Packaging;

/// <summary>
/// Defines the GlossaryDocumentPart
/// </summary>
public interface IGlossaryDocumentPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IAlternativeFormatImportPart? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IChartPart? ChartParts { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IFooterPart? FooterParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.IGlossaryDocument? GlossaryDocument { get ; set; }
  
  /// <summary>
  /// Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IHeaderPart? HeaderParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IModel3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public DocumentModel.Packaging.IWordprocessingPrinterSettingsPart? WordprocessingPrinterSettingsParts { get ; set; }
  
}
