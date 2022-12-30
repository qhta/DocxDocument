namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FooterPart
/// </summary>
public partial class FooterPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts { get; }
  
  /// <summary>
  /// Gets the ChartParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get; }
  
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Footer? Footer { get; set; }
  
  /// <summary>
  /// Gets the ImageParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the FooterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; }
  
  public String? RelationshipType { get; }
  
}
