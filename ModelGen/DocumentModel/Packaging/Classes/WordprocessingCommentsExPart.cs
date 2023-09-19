namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingCommentsExPart
/// </summary>
public partial class WordprocessingCommentsExPart
{
  
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? AlternativeFormatImportParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ChartParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? ChartParts { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsEx? CommentsEx { get; set; }
  
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramColorsParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? DiagramColorsParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramDataParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? DiagramDataParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? DiagramLayoutDefinitionParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? DiagramPersistLayoutParts { get; set; }
  
  
  /// <summary>
  ///   Gets the DiagramStyleParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? DiagramStyleParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? EmbeddedControlPersistenceParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? EmbeddedObjectParts { get; set; }
  
  
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? EmbeddedPackageParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ExtendedChartParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? ExtendedChartParts { get; set; }
  
  
  /// <summary>
  ///   Gets the ImageParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? ImageParts { get; set; }
  
  
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsExPart
  /// </summary>
  public Collection? Model3DReferenceRelationshipParts { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
