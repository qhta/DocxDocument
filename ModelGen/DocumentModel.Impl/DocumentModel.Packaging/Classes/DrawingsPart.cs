namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DrawingsPart
/// </summary>
public class DrawingsPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, DrawingsPart
{
  /// <summary>
  /// Gets the ChartParts of the DrawingsPart
  /// </summary>
  public ChartPart? ChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the DrawingsPart
  /// </summary>
  public OpenXmlPartContainer? CustomXmlParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the DrawingsPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the DrawingsPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the DrawingsPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the DrawingsPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the DrawingsPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the DrawingsPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DrawingsPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the DrawingsPart
  /// </summary>
  public WebExtensionPart? WebExtensionParts
  {
    get;
    set;
  }
  
}
