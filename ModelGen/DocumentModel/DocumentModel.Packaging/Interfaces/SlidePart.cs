namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlidePart
/// </summary>
public partial interface SlidePart
{
  /// <summary>
  /// Gets the ChartParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get; }
  
  /// <summary>
  /// Gets the commentParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.PowerPointCommentPart>? commentParts { get; }
  
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts { get; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get; }
  
  /// <summary>
  /// Gets the ImageParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; }
  
  /// <summary>
  /// Gets the NotesSlidePart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.NotesSlidePart? NotesSlidePart { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets the SlideCommentsPart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.SlideCommentsPart? SlideCommentsPart { get; }
  
  /// <summary>
  /// Gets the SlideLayoutPart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.SlideLayoutPart? SlideLayoutPart { get; }
  
  /// <summary>
  /// Gets the SlideParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlidePart>? SlideParts { get; }
  
  /// <summary>
  /// Gets the SlideSyncDataPart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.SlideSyncDataPart? SlideSyncDataPart { get; }
  
  /// <summary>
  /// Gets the ThemeOverridePart of the SlidePart
  /// </summary>
  public DocumentModel.Packaging.ThemeOverridePart? ThemeOverridePart { get; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.UserDefinedTagsPart>? UserDefinedTagsParts { get; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.VmlDrawingPart>? VmlDrawingParts { get; }
  
  /// <summary>
  /// Gets the WebExtensionParts of the SlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.WebExtensionPart>? WebExtensionParts { get; }
  
}
