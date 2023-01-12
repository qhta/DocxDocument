namespace DocumentModel.Packaging;

/// <summary>
/// Defines the MainDocumentPart
/// </summary>
public partial class MainDocumentPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts { get; set; }
  
  /// <summary>
  /// Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts { get; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Document? Document { get; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get; set; }
  
  /// <summary>
  /// Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.FooterPart>? FooterParts { get; set; }
  
  /// <summary>
  /// Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.HeaderPart>? HeaderParts { get; set; }
  
  /// <summary>
  /// Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts { get; set; }
  
}
