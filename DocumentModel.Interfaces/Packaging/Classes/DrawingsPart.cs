namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DrawingsPart
/// </summary>
public interface DrawingsPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the ChartParts of the DrawingsPart
  /// </summary>
  public ChartParts ChartParts { get; set; }
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the CustomXmlParts of the DrawingsPart
  /// </summary>
  public CustomXmlParts CustomXmlParts { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the DrawingsPart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the DrawingsPart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the DrawingsPart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the DrawingsPart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the DrawingsPart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the DrawingsPart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the DrawingsPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets the WebExtensionParts of the DrawingsPart
  /// </summary>
  public WebExtensionParts WebExtensionParts { get; set; }
}