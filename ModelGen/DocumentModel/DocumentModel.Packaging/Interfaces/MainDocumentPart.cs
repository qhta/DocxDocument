namespace DocumentModel.Packaging;

/// <summary>
/// Defines the MainDocumentPart
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument")]
[PartConstraint(typeof(DocumentModel.Packaging.CustomXmlPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.GlossaryDocumentPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ThemePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.ThumbnailPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.WordprocessingCommentsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.DocumentSettingsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.EndnotesPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.FontTablePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.FootnotesPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.NumberingDefinitionsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.StyleDefinitionsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.StylesWithEffectsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.WebSettingsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.FooterPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.HeaderPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.WordprocessingPrinterSettingsPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.CustomizationPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.VbaProjectPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.WordprocessingCommentsExPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.WordprocessingPeoplePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.WordprocessingCommentsIdsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.DocumentTasksPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.WordCommentsExtensiblePart), false, false)]
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
public interface MainDocumentPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the MainDocumentPart
  /// </summary>
  public AlternativeFormatImportPart? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the MainDocumentPart
  /// </summary>
  public ChartPart? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the MainDocumentPart
  /// </summary>
  public CustomXmlPart? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the MainDocumentPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the MainDocumentPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the MainDocumentPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the MainDocumentPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Document? Document { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the MainDocumentPart
  /// </summary>
  public EmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the MainDocumentPart
  /// </summary>
  public EmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the MainDocumentPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the FooterParts of the MainDocumentPart
  /// </summary>
  public FooterPart? FooterParts { get ; set; }
  
  /// <summary>
  /// Gets the HeaderParts of the MainDocumentPart
  /// </summary>
  public HeaderPart? HeaderParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the MainDocumentPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the MainDocumentPart
  /// </summary>
  public Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
  /// </summary>
  public WordprocessingPrinterSettingsPart? WordprocessingPrinterSettingsParts { get ; set; }
  
}
