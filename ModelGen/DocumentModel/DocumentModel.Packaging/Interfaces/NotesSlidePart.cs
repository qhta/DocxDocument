namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NotesSlidePart
/// </summary>
public partial interface NotesSlidePart
{
  /// <summary>
  /// Gets the ChartParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ChartPart>? ChartParts { get; }
  
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomXmlPart>? CustomXmlParts { get; }
  
  /// <summary>
  /// Gets the DiagramColorsParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramColorsPart>? DiagramColorsParts { get; }
  
  /// <summary>
  /// Gets the DiagramDataParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramDataPart>? DiagramDataParts { get; }
  
  /// <summary>
  /// Gets the DiagramLayoutDefinitionParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; }
  
  /// <summary>
  /// Gets the DiagramStyleParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.DiagramStylePart>? DiagramStyleParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get; }
  
  /// <summary>
  /// Gets the ExtendedChartParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ExtendedChartPart>? ExtendedChartParts { get; }
  
  /// <summary>
  /// Gets the ImageParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; }
  
  /// <summary>
  /// Gets the NotesMasterPart of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.NotesMasterPart? NotesMasterPart { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets the SlidePart of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.SlidePart? SlidePart { get; }
  
  /// <summary>
  /// Gets the ThemeOverridePart of the NotesSlidePart
  /// </summary>
  public DocumentModel.Packaging.ThemeOverridePart? ThemeOverridePart { get; }
  
  /// <summary>
  /// Gets the UserDefinedTagsParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.UserDefinedTagsPart>? UserDefinedTagsParts { get; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the NotesSlidePart
  /// </summary>
  public Collection<DocumentModel.Packaging.VmlDrawingPart>? VmlDrawingParts { get; }
  
}
