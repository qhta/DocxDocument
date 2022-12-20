namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DrawingsPart
/// </summary>
public partial interface DrawingsPart
{
  /// <summary>
  /// Gets the ChartParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get; }
  
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts { get; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get; }
  
  /// <summary>
  /// Gets the ImageParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets the WebExtensionParts of the DrawingsPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WebExtensionPart>? WebExtensionParts { get; }
  
}
