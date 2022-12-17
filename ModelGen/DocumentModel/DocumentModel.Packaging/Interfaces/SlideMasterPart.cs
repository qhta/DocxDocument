namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideMasterPart
/// </summary>
public interface SlideMasterPart
{
  /// <summary>
  /// Gets the ChartParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlideLayoutParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlideLayoutPart>? SlideLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlidePart>? SlideParts { get ; set; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.UserDefinedTagsPart>? UserDefinedTagsParts { get ; set; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlideMasterPart
  /// </summary>
  public Collection<DocumentModel.Packaging.VmlDrawingPart>? VmlDrawingParts { get ; set; }
  
}
