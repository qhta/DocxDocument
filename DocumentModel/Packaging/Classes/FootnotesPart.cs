namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FootnotesPart
/// </summary>
public partial class FootnotesPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts { get; }
  
  /// <summary>
  /// Gets the ChartParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get; }
  
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Footnotes? Footnotes { get; set; }
  
  /// <summary>
  /// Gets the ImageParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the FootnotesPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; }
  
  public String? RelationshipType { get; }
  
}
