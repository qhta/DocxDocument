namespace DocumentModel.Packaging;

/// <summary>
/// Defines the MainDocumentPart
/// </summary>
public partial interface MainDocumentPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts { get; }
  
  /// <summary>
  /// Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get; }
  
  /// <summary>
  /// Gets the CustomizationPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.CustomizationPart? CustomizationPart { get; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts { get; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Document? Document { get; set; }
  
  /// <summary>
  /// Gets the DocumentSettingsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.DocumentSettingsPart? DocumentSettingsPart { get; }
  
  /// <summary>
  /// Gets the DocumentTasksPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.DocumentTasksPart? DocumentTasksPart { get; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get; }
  
  /// <summary>
  /// Gets the EndnotesPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.EndnotesPart? EndnotesPart { get; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get; }
  
  /// <summary>
  /// Gets the FontTablePart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.FontTablePart? FontTablePart { get; }
  
  /// <summary>
  /// Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.FooterPart>? FooterParts { get; }
  
  /// <summary>
  /// Gets the FootnotesPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.FootnotesPart? FootnotesPart { get; }
  
  /// <summary>
  /// Gets the GlossaryDocumentPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.GlossaryDocumentPart? GlossaryDocumentPart { get; }
  
  /// <summary>
  /// Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.HeaderPart>? HeaderParts { get; }
  
  /// <summary>
  /// Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; }
  
  /// <summary>
  /// Gets the NumberingDefinitionsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.NumberingDefinitionsPart? NumberingDefinitionsPart { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets the StyleDefinitionsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.StyleDefinitionsPart? StyleDefinitionsPart { get; }
  
  /// <summary>
  /// Gets the StylesWithEffectsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.StylesWithEffectsPart? StylesWithEffectsPart { get; }
  
  /// <summary>
  /// Gets the ThemePart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.ThemePart? ThemePart { get; }
  
  /// <summary>
  /// Gets the ThumbnailPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.ThumbnailPart? ThumbnailPart { get; }
  
  /// <summary>
  /// Gets the VbaProjectPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.VbaProjectPart? VbaProjectPart { get; }
  
  /// <summary>
  /// Gets the WebSettingsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WebSettingsPart? WebSettingsPart { get; }
  
  /// <summary>
  /// Gets the WordCommentsExtensiblePart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordCommentsExtensiblePart? WordCommentsExtensiblePart { get; }
  
  /// <summary>
  /// Gets the WordprocessingCommentsExPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsExPart? WordprocessingCommentsExPart { get; }
  
  /// <summary>
  /// Gets the WordprocessingCommentsIdsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsIdsPart? WordprocessingCommentsIdsPart { get; }
  
  /// <summary>
  /// Gets the WordprocessingCommentsPart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsPart? WordprocessingCommentsPart { get; }
  
  /// <summary>
  /// Gets the WordprocessingPeoplePart of the MainDocumentPart
  /// </summary>
  public DocumentModel.Packaging.WordprocessingPeoplePart? WordprocessingPeoplePart { get; }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts { get; }
  
}
