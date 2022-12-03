namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DrawingsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.drawing+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing")]
[PartConstraint(typeof(DocumentModel.Packaging.ChartPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ExtendedChartPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramColorsPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramDataPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramPersistLayoutPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramLayoutDefinitionPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DiagramStylePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.CustomXmlPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.WebExtensionPart), false, true)]
public interface DrawingsPart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets the ChartParts of the DrawingsPart
  /// </summary>
  public ChartPart? ChartParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the DrawingsPart
  /// </summary>
  public CustomXmlPart? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the DrawingsPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the DrawingsPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the DrawingsPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the DrawingsPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the DrawingsPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the DrawingsPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DrawingsPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the WebExtensionParts of the DrawingsPart
  /// </summary>
  public WebExtensionPart? WebExtensionParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawings.WorksheetDrawing? WorksheetDrawing { get ; set; }
  
}
