namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideLayoutPart
/// </summary>
public class SlideLayoutPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlideLayoutPart
{
  public new DocumentFormat.OpenXml.Packaging.SlideLayoutPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlideLayoutPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets the ChartParts of the SlideLayoutPart
  /// </summary>
  public ChartPart? ChartParts
  {
    get;
    set;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlideLayoutPart
  /// </summary>
  public CustomXmlPart? CustomXmlParts
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
  public EmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts
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
  public EmbeddedObjectPart? EmbeddedObjectParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlideLayoutPart
  /// </summary>
  public EmbeddedPackagePart? EmbeddedPackageParts
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
  public ImagePart? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlideLayoutPart
  /// </summary>
  public Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts
  {
    get;
    set;
  }
  
  public override String? RelationshipType
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
  public UserDefinedTagsPart? UserDefinedTagsParts
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
