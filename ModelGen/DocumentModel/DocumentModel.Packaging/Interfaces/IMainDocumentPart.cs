namespace DocumentModel.Packaging;

/// <summary>
/// Defines the MainDocumentPart
/// </summary>
public interface IMainDocumentPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ChartPart>? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets the CustomizationPart of the MainDocumentPart
  /// </summary>
  public CustomizationPart? CustomizationPart { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.CustomXmlPart>? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramDataPart>? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramStylePart>? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public IDocument? Document { get ; set; }
  
  /// <summary>
  /// Gets the DocumentSettingsPart of the MainDocumentPart
  /// </summary>
  public IDocumentSettingsPart? DocumentSettingsPart { get ; set; }
  
  /// <summary>
  /// Gets the DocumentTasksPart of the MainDocumentPart
  /// </summary>
  public DocumentTasksPart? DocumentTasksPart { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the EndnotesPart of the MainDocumentPart
  /// </summary>
  public IEndnotesPart? EndnotesPart { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the FontTablePart of the MainDocumentPart
  /// </summary>
  public IFontTablePart? FontTablePart { get ; set; }
  
  /// <summary>
  /// Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.FooterPart>? FooterParts { get ; set; }
  
  /// <summary>
  /// Gets the FootnotesPart of the MainDocumentPart
  /// </summary>
  public IFootnotesPart? FootnotesPart { get ; set; }
  
  /// <summary>
  /// Gets the GlossaryDocumentPart of the MainDocumentPart
  /// </summary>
  public IGlossaryDocumentPart? GlossaryDocumentPart { get ; set; }
  
  /// <summary>
  /// Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.HeaderPart>? HeaderParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ImagePart>? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get ; set; }
  
  /// <summary>
  /// Gets the NumberingDefinitionsPart of the MainDocumentPart
  /// </summary>
  public INumberingDefinitionsPart? NumberingDefinitionsPart { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the StyleDefinitionsPart of the MainDocumentPart
  /// </summary>
  public StyleDefinitionsPart? StyleDefinitionsPart { get ; set; }
  
  /// <summary>
  /// Gets the StylesWithEffectsPart of the MainDocumentPart
  /// </summary>
  public StylesWithEffectsPart? StylesWithEffectsPart { get ; set; }
  
  /// <summary>
  /// Gets the ThemePart of the MainDocumentPart
  /// </summary>
  public ThemePart? ThemePart { get ; set; }
  
  /// <summary>
  /// Gets the ThumbnailPart of the MainDocumentPart
  /// </summary>
  public ThumbnailPart? ThumbnailPart { get ; set; }
  
  /// <summary>
  /// Gets the VbaProjectPart of the MainDocumentPart
  /// </summary>
  public VbaProjectPart? VbaProjectPart { get ; set; }
  
  /// <summary>
  /// Gets the WebSettingsPart of the MainDocumentPart
  /// </summary>
  public IWebSettingsPart? WebSettingsPart { get ; set; }
  
  /// <summary>
  /// Gets the WordCommentsExtensiblePart of the MainDocumentPart
  /// </summary>
  public WordCommentsExtensiblePart? WordCommentsExtensiblePart { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingCommentsExPart of the MainDocumentPart
  /// </summary>
  public WordprocessingCommentsExPart? WordprocessingCommentsExPart { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingCommentsIdsPart of the MainDocumentPart
  /// </summary>
  public WordprocessingCommentsIdsPart? WordprocessingCommentsIdsPart { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingCommentsPart of the MainDocumentPart
  /// </summary>
  public IWordprocessingCommentsPart? WordprocessingCommentsPart { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingPeoplePart of the MainDocumentPart
  /// </summary>
  public WordprocessingPeoplePart? WordprocessingPeoplePart { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts { get ; set; }
  
}
