namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlidePart
/// </summary>
public interface SlidePart
{
  /// <summary>
  /// Gets the ChartParts of the SlidePart
  /// </summary>
  public ChartPart? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets the commentParts of the SlidePart
  /// </summary>
  public OpenXmlPartContainer? commentParts { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlidePart
  /// </summary>
  public OpenXmlPartContainer? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlidePart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlidePart
  /// </summary>
  public DiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlidePart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlidePart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlidePart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlidePart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlidePart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlidePart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlidePart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the SlidePart
  /// </summary>
  public OpenXmlPartContainer? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlidePart
  /// </summary>
  public OpenXmlPartContainer? Model3DReferenceRelationshipParts { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the SlidePart
  /// </summary>
  public SlidePart? SlideParts { get ; set; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlidePart
  /// </summary>
  public OpenXmlPartContainer? UserDefinedTagsParts { get ; set; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlidePart
  /// </summary>
  public VmlDrawingPart? VmlDrawingParts { get ; set; }
  
  /// <summary>
  /// Gets the WebExtensionParts of the SlidePart
  /// </summary>
  public WebExtensionPart? WebExtensionParts { get ; set; }
  
}
