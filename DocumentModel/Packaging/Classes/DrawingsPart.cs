namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DrawingsPart
/// </summary>
public class DrawingsPart: ModelElement
{
  /// <summary>
  ///   Gets the ChartParts of the DrawingsPart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the CustomXmlParts of the DrawingsPart
  /// </summary>
  public Collection<CustomXmlPart>? CustomXmlParts { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the DrawingsPart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the DrawingsPart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the DrawingsPart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the DrawingsPart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the DrawingsPart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the DrawingsPart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the DrawingsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets the WebExtensionParts of the DrawingsPart
  /// </summary>
  public Collection<WebExtensionPart>? WebExtensionParts { get; set; }
}