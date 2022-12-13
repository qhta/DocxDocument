namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NotesSlidePart
/// </summary>
public interface NotesSlidePart
{
  /// <summary>
  /// Gets the ChartParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.ChartPart? ChartParts { get ; set; }
  
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.CustomXmlPart? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramColorsPart? DiagramColorsParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramDataPart? DiagramDataParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramLayoutDefinitionPart? DiagramLayoutDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramPersistLayoutPart? DiagramPersistLayoutParts { get ; set; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.DiagramStylePart? DiagramStyleParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.EmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.ExtendedChartPart? ExtendedChartParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.UserDefinedTagsPart? UserDefinedTagsParts { get ; set; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.VmlDrawingPart? VmlDrawingParts { get ; set; }
  
}
