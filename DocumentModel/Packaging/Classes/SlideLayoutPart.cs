namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideLayoutPart
/// </summary>
public partial class SlideLayoutPart
{
  /// <summary>
  /// Gets the ChartParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get; }
  
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts { get; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get; }
  
  /// <summary>
  /// Gets the ImageParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets the SlideParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlidePart>? SlideParts { get; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.UserDefinedTagsPart>? UserDefinedTagsParts { get; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlideLayoutPart
  /// </summary>
  public Collection<DocumentModel.Packaging.VmlDrawingPart>? VmlDrawingParts { get; }
  
}
