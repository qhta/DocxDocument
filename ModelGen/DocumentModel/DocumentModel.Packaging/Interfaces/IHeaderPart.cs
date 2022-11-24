namespace DocumentModel.Packaging;

/// <summary>
/// Defines the HeaderPart
/// </summary>
public interface IHeaderPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ChartPart>? ChartParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramDataPart>? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramStylePart>? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public IHeader? Header { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ImagePart>? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the HeaderPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
