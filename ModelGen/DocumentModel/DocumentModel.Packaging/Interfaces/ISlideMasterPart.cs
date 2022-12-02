namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideMasterPart
/// </summary>
public interface ISlideMasterPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the ChartParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IChartPart? ChartParts { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.ICustomXmlPart? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IDiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IEmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IModel3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlideLayoutParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.ISlideLayoutPart? SlideLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.ISlideMaster? SlideMaster { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.ISlidePart? SlideParts { get ; set; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IUserDefinedTagsPart? UserDefinedTagsParts { get ; set; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlideMasterPart
  /// </summary>
  public DocumentModel.Packaging.IVmlDrawingPart? VmlDrawingParts { get ; set; }
  
}
