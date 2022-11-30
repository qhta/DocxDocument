namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlidePart
/// </summary>
public interface ISlidePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the ChartParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IChartPart? ChartParts { get ; set; }
  
  /// <summary>
  /// Gets the commentParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IPowerPointCommentPart? commentParts { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.ICustomXmlPart? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IDiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IDiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IDiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IDiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IDiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IModel3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.ISlide? Slide { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.ISlidePart? SlideParts { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IUserDefinedTagsPart? UserDefinedTagsParts { get ; set; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IVmlDrawingPart? VmlDrawingParts { get ; set; }
  
  /// <summary>
  /// Gets the WebExtensionParts of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.IWebExtensionPart? WebExtensionParts { get ; set; }
  
}
