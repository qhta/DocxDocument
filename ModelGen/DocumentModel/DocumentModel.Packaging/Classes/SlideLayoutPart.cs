namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideLayoutPart
/// </summary>
public class SlideLayoutPart: DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets the ChartParts of the SlideLayoutPart
  /// </summary>
  public ChartPart? ChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlideLayoutPart
  /// </summary>
  public OpenXmlPartContainer? CustomXmlParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlideLayoutPart
  /// </summary>
  public DiagramColorsPart? DiagramColorsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlideLayoutPart
  /// </summary>
  public DiagramDataPart? DiagramDataParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlideLayoutPart
  /// </summary>
  public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlideLayoutPart
  /// </summary>
  public DiagramPersistLayoutPart? DiagramPersistLayoutParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlideLayoutPart
  /// </summary>
  public DiagramStylePart? DiagramStyleParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideLayoutPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedControlPersistenceBinaryDataParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlideLayoutPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlideLayoutPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedObjectParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlideLayoutPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedPackageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlideLayoutPart
  /// </summary>
  public ExtendedChartPart? ExtendedChartParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the SlideLayoutPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlideLayoutPart
  /// </summary>
  public OpenXmlPartContainer? Model3DReferenceRelationshipParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the SlideParts of the SlideLayoutPart
  /// </summary>
  public SlidePart? SlideParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlideLayoutPart
  /// </summary>
  public OpenXmlPartContainer? UserDefinedTagsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlideLayoutPart
  /// </summary>
  public VmlDrawingPart? VmlDrawingParts
  {
    get;
    set;
  }
  
}
