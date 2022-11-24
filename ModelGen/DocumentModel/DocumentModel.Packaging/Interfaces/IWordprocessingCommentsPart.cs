namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingCommentsPart
/// </summary>
public interface IWordprocessingCommentsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart>? AlternativeFormatImportParts { get ; set; }
  
  /// <summary>
  /// Gets the ChartParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ChartPart>? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public IComments? Comments { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramColorsPart>? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramDataPart>? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.DiagramStylePart>? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ExtendedChartPart>? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ImagePart>? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
