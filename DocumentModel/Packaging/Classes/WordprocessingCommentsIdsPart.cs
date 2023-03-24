using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WordprocessingCommentsIdsPart
/// </summary>
public class WordprocessingCommentsIdsPart: ModelElement
{
  /// <summary>
  ///   Gets the AlternativeFormatImportParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<AlternativeFormatImportPart>? AlternativeFormatImportParts { get; set; }

  /// <summary>
  ///   Gets the ChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<ChartPart>? ChartParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CommentsIds? CommentsIds { get; set; }

  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the DiagramColorsParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<DiagramColorsPart>? DiagramColorsParts { get; set; }

  /// <summary>
  ///   Gets the DiagramDataParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<DiagramDataPart>? DiagramDataParts { get; set; }

  /// <summary>
  ///   Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<DiagramLayoutDefinitionPart>? DiagramLayoutDefinitionParts { get; set; }

  /// <summary>
  ///   Gets the DiagramPersistLayoutParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<DiagramPersistLayoutPart>? DiagramPersistLayoutParts { get; set; }

  /// <summary>
  ///   Gets the DiagramStyleParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<DiagramStylePart>? DiagramStyleParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedObjectParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }

  /// <summary>
  ///   Gets the EmbeddedPackageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }

  /// <summary>
  ///   Gets the ExtendedChartParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<ExtendedChartPart>? ExtendedChartParts { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsIdsPart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }

  public String? RelationshipType { get; set; }
}