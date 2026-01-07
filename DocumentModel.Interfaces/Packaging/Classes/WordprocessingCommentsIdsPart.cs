using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordprocessingCommentsIdsPart
/// </summary>
public interface WordprocessingCommentsIdsPart: OpenXmlPart
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public AlternativeFormatImportParts AlternativeFormatImportParts { get; set; }
  /// <summary>
  ///   Gets the ChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ChartParts ChartParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CommentsIds? CommentsIds { get; set; }
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the DiagramColorsParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramColorsParts DiagramColorsParts { get; set; }
  /// <summary>
  ///   Gets the DiagramDataParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramDataParts DiagramDataParts { get; set; }
  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramLayoutDefinitionParts DiagramLayoutDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramPersistLayoutParts DiagramPersistLayoutParts { get; set; }
  /// <summary>
  ///   Gets the DiagramStyleParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public DiagramStyleParts DiagramStyleParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedControlPersistenceParts EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ExtendedChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ExtendedChartParts ExtendedChartParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }
  public string? RelationshipType { get; set; }
}