namespace DocumentModel.Packaging;

/// <summary>
/// Defines the GlossaryDocumentPart
/// </summary>
public interface GlossaryDocumentPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the FooterParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.FooterPart>? FooterParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.GlossaryDocument? GlossaryDocument { get ; set; }
  
  /// <summary>
  /// Gets the HeaderParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.HeaderPart>? HeaderParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts { get ; set; }
  
}
